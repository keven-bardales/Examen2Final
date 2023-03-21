using Examen2Progra2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Examen2Progra2.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Examen2Progra2.Views;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;

namespace Examen2Progra2.ViewModel
{
    public class ViewModelMateria: BaseViewModel

    {

        #region VARIABLES
        private Materia materia1 = AppData.maestroInicial.materiaInicial;

        private ObservableCollection<Alumno> alumnos;

        private Alumno alumnoSeleccionado;

        #endregion

        #region CONSTRUCTOR
        public ViewModelMateria(INavigation navigation, Materia materia)
        {
            Navigation = navigation;
            materia1 = AppData.maestroInicial.materiaInicial;
            Alumnos = AppData.maestroInicial.materiaInicial.listaAlumnos;
            OnPropertyChanged(nameof(Alumnos));

        }



        #endregion

        #region OBJETOS
        public ObservableCollection<Alumno> Alumnos
        {
            get => alumnos;
            set
            {
                alumnos = value;
                if(alumnos != value)
                {
                    alumnos = value;
                    OnPropertyChanged(nameof(Alumnos));
                }
            }
        }

        public Alumno AlumnoSeleccionado
        {
            get => alumnoSeleccionado;
            set
            {
                alumnoSeleccionado = value;
                if(alumnoSeleccionado != value)
                {
                    alumnoSeleccionado = value;
                    OnPropertyChanged(nameof(AlumnoSeleccionado));
                }
            }
        }

        public Materia Materia1
        {
            get => materia1;
            set
            {
                materia1 = value;
                if(materia1 != value)
                {
                    materia1 = value;
                    OnPropertyChanged(nameof(Materia1));
                }
            }
        }

        #endregion

        #region COMANDOS
        public ICommand NavigateAlumnoCommand => new Command(async () =>
        {

            if( AlumnoSeleccionado != null)
            {
                AppData.maestroInicial.materiaInicial.alumnoSeleccionado = AlumnoSeleccionado;
                await Application.Current.MainPage.Navigation.PushAsync(new ViewAlumno(AlumnoSeleccionado));
            }


        });

        public ICommand NavigateMenuCommand => new Command<string>(async (numPagina) => await AbrirPagina(numPagina));

        #endregion

        #region PROCESOS

       


        public async Task AbrirPagina(string numPagina)
        {
            if(numPagina == "1") {

                await Application.Current.MainPage.Navigation.PushAsync(new ViewAsistencia(Materia1));

            }else if(numPagina == "2")
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ViewAddAlumno(Materia1));
            }
        }

        #endregion





    }
}
