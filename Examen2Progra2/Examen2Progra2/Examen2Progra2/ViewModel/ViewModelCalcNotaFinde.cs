using Examen2Progra2.Models;
using Examen2Progra2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen2Progra2.ViewModel
{
    public class ViewModelCalcNotaFinde : BaseViewModel
    {



        #region VARIABLES
       private AlumnoFinde alumnoactual;
    
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        #endregion

        #region CONSTRUCTOR
        public ViewModelCalcNotaFinde(INavigation navigation, AlumnoFinde alumnoActual)
        {
            Navigation = navigation;
            alumnoactual = alumnoActual;
            
        }
        #endregion

        #region OBJETOS
      
        public double Nota1
        {
            get { return nota1; }
            set
            {
                SetValue(ref nota1, value);
            }
        }

        public double Nota2
        {
            get { return nota2; }
            set
            {
                SetValue(ref nota2, value);
            }
        }

        public double Nota3
        {
            get { return nota3; }
            set
            {
                SetValue(ref nota3, value);
            }
        }

        public double Nota4
        {
            get { return nota4; }
            set
            {
                SetValue(ref nota4, value);
            }
        }

        #endregion

        #region PROCESOS
        public void GuardarNotas()
        {
            alumnoactual.GetNotas()[0] = nota1;
            alumnoactual.GetNotas()[1] = nota2;
            alumnoactual.GetNotas()[2] = nota3;
            alumnoactual.GetNotas()[3] = nota4;

            alumnoactual.calcPromedio();
            AppData.maestroInicial.materiaInicial.alumnoSeleccionado = alumnoactual;

            AppData.maestroInicial.materiaInicial.ActualizarAlumnoMateria(this.alumnoactual);

            AppData.maestroInicial.ActualizarMateriaMaestro(AppData.maestroInicial.materiaInicial);
        }
        #endregion

        #region COMANDOS
        public ICommand GuardarNotasCommand => new Command(GuardarNotas);
        #endregion

    }
}
