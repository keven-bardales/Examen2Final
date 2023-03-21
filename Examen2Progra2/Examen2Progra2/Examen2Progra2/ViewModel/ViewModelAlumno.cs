using Examen2Progra2.Models;
using Examen2Progra2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen2Progra2.ViewModel
{
    public class ViewModelAlumno : BaseViewModel
    {

        #region VARIABLES
        private Alumno alumnoActual;
        private string nombre;
        private double promedio;
        private int asistenciasCount;
        private int inasistenciasCount;
        #endregion

        #region CONSTRUCTOR
        public ViewModelAlumno(INavigation navigation, Alumno alumnoActual)
        {
            Navigation = navigation;
            this.alumnoActual = AppData.maestroInicial.materiaInicial.alumnoSeleccionado;
            CargarDatosAlumno();
        }
        #endregion

        #region OBJETOS

        public Alumno AlumnoActual
        {
            get { return alumnoActual;}
            set
            {
                SetValue(ref alumnoActual, value);
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                SetValue(ref nombre, value);
            }
        }

        public double Promedio
        {
            get { return promedio; }
            set
            {
                SetValue(ref promedio, value);
            }
        }

        public int AsistenciasCount
        {
            get { return asistenciasCount; }
            set
            {
                SetValue(ref asistenciasCount, value);
            }
        }

        public int InasistenciasCount
        {
            get { return inasistenciasCount; }
            set
            {
                SetValue(ref inasistenciasCount, value);
            }
        }



        #endregion

        #region PROCESOS
        private void CargarDatosAlumno()
        {
            Nombre = alumnoActual.nombreAlumno;
            Promedio = alumnoActual.promedio;
            AsistenciasCount = alumnoActual.AsistenciasCount;
            InasistenciasCount = alumnoActual.InasistenciasCount;

        }

        public async Task ViewCalcPromedio()
        {
            if(alumnoActual.tipoAlumno == 1)
            {
                AlumnoDiasDeSemana a = (AlumnoDiasDeSemana)AlumnoActual;
                await Application.Current.MainPage.Navigation.PushAsync(new ViewCalcDiasSemana(a));
            }else if(alumnoActual.tipoAlumno == 2)
            {
                AlumnoFinde a = (AlumnoFinde)AlumnoActual;
                await Application.Current.MainPage.Navigation.PushAsync(new ViewCalcNotaFinde(a));
            }
        }

        #endregion

        #region COMANDOS
        public ICommand CalcNotaCommand => new Command(async () =>
        {
            await ViewCalcPromedio();
        });
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
