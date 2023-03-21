using Examen2Progra2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen2Progra2.ViewModel
{
    public class ViewModelAsistencia : BaseViewModel
    {
        #region VARIABLES
        private Materia materiaSeleccionada = AppData.maestroInicial.materiaInicial;
        private ObservableCollection<Alumno> listaAlumnos;
        #endregion

        #region CONSTRUCTOR
        public ViewModelAsistencia(INavigation navigation, Materia materia)
        {
            Navigation = navigation;
            ListaAlumnos = AppData.maestroInicial.materiaInicial.listaAlumnos;
        }
        #endregion

        #region OBJETOS
        public Materia MateriaSeleccionada
        {
            get => materiaSeleccionada;
            set => SetValue(ref materiaSeleccionada, value);
        }

        public ObservableCollection<Alumno> ListaAlumnos
        {
            get => listaAlumnos;
            set => SetValue(ref listaAlumnos, value);
        }
        #endregion

        #region COMANDOS
        public ICommand GuardarAsistenciasCommand => new Command(GuardarAsistencias);
        #endregion

        #region PROCESOS
        public void GuardarAsistencias()
        {
            foreach (Alumno alumno in ListaAlumnos)
            {
                alumno.Asistencias.Add(alumno.presente);

           
            }

            AppData.maestroInicial.materiaInicial.listaAlumnos = ListaAlumnos;

            AppData.maestroInicial.ActualizarMateriaMaestro(AppData.maestroInicial.materiaInicial);
        }
        #endregion
    }
}
