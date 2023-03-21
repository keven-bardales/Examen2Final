using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Examen2Progra2.Models;
using Examen2Progra2.Views;
using Xamarin.Forms;

namespace Examen2Progra2.ViewModel
{
    public class ViewmodelMaestro:BaseViewModel
    {
        #region VARIABLES


        private string mensajeBienvenida;
        private Maestro maestroInicial = AppData.maestroInicial;
        private Materia materiaSeleccionada { get; set; }
        private ObservableCollection<Materia> materias = new ObservableCollection<Materia>();

        #endregion

        #region CONSTRUCTOR
        public ViewmodelMaestro(INavigation navigation)
        {
            Navigation = navigation;

            MensajeBienvenida = $"Hola Bienvenido a la aplicación Maestro " +
                $"{maestroInicial.nombreMaestro}";
            Materias = maestroInicial.listaClases;

           
        }


        #endregion

        #region OBJETOS
        public ObservableCollection<Materia> Materias
        {
            get => materias;
            set
            {
                if (materias != value)
                {
                    materias = value;
                    OnPropertyChanged(nameof(Materias));
                }

            }
        }


        public string MensajeBienvenida
        {
            get { return mensajeBienvenida; }
            set
            {
                SetValue(ref mensajeBienvenida, value);
            }
        }


        public Materia MateriaSeleccionada
        {
            get => materiaSeleccionada;
            set
            {
                materiaSeleccionada = value;
                if (materiaSeleccionada != value)
                {
                    materiaSeleccionada = value;
                    OnPropertyChanged(nameof(MateriaSeleccionada));
                }
            }
        }

        #endregion



        #region PROCESOS

        public async Task NavigateMateria()
        {
            if (MateriaSeleccionada != null)
            {
                AppData.maestroInicial.materiaInicial = MateriaSeleccionada;
                await Application.Current.MainPage.Navigation.PushAsync(new ViewMateria(MateriaSeleccionada));
            }
        }

        public void ProcesoSimple()
        {

        }

        public async Task CrearMateria()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CrearMateria());
        }

        #endregion

        #region COMANDOS
        

        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);

        public ICommand NavigateMateriaCommand => new Command(async () =>
        {
            await NavigateMateria();
        });

        public ICommand CreateMateriaCommand => new Command(async () =>
        {
            await CrearMateria();
        });
        #endregion
    }
}