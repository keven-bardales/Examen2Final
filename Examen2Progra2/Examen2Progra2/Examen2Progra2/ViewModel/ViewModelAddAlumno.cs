using Examen2Progra2.Models;
using Examen2Progra2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen2Progra2.ViewModel
{
    public class ViewModelAddAlumno : BaseViewModel
    {

        #region VARIABLES
        private Materia materia;
        private string nombreAlumno2;
        #endregion

        #region CONSTRUCTOR
        public ViewModelAddAlumno(INavigation navigation, Materia materia)
        {
            Navigation = navigation;
            this.materia = AppData.maestroInicial.materiaInicial;



        }
        #endregion

        #region OBJETOS



       public string NombreAlumno2
        {
            get => nombreAlumno2;
            set
            {
                if(nombreAlumno2 != value)
                {
                    nombreAlumno2 = value;
                    OnpropertyChanged(nameof(NombreAlumno2));    
                }
            }
        }

 

        public Materia Materia
        {
            get => materia;
            set
            {
                if(materia != value) { 
                
                materia = value;
                    OnPropertyChanged(nameof(materia));
                }
            }
        }

        #endregion

        #region PROCESOS
        public void AddAlumno()
        {
            
            if (materia.tipoMateria == "Fin De Semana")
            {
                AlumnoFinde alumno = new AlumnoFinde()
                {
                    nombreAlumno = NombreAlumno2
                };
                materia.listaAlumnos.Add(alumno);
            }
            else if (materia.tipoMateria == "Dias De Semana")
            {
                AlumnoDiasDeSemana alumno = new AlumnoDiasDeSemana()
                {
                    nombreAlumno = this.NombreAlumno2
                };
                materia.listaAlumnos.Add(alumno);
            }

         
            OnPropertyChanged(nameof(materia.listaAlumnos));

            AppData.maestroInicial.materiaInicial = materia;

            AppData.maestroInicial.ActualizarMateriaMaestro(materia);

        }





        #endregion

        #region COMANDOS
        public ICommand AgregarAlumnoCommand => new Command(AddAlumno);
        #endregion

    }
}
