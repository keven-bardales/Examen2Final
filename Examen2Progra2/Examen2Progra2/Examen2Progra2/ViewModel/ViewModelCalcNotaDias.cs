using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Examen2Progra2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace Examen2Progra2.ViewModel
{
    public class ViewModelCalcNotaDias : BaseViewModel
    {


        #region VARIABLES
        private AlumnoDiasDeSemana alumno;
        private string diaSeleccionado;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        #endregion

        #region CONSTRUCTOR
        public ViewModelCalcNotaDias(INavigation navigation, AlumnoDiasDeSemana alumnoActual)
        {
            Navigation = navigation;
            this.alumno = alumnoActual;

        }
        #endregion

        #region OBJETOS
        public string DiaSeleccionado
        {
            get { return diaSeleccionado; }
            set
            {
                SetValue(ref diaSeleccionado, value);
            }
        }

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
        public async Task GuardarNotas()
        {
            switch (diaSeleccionado)
            {
                case "Lunes":
                    alumno.GetNotas()[0, 0] = nota1;
                    alumno.GetNotas()[0, 1] = nota2;
                    alumno.GetNotas()[0, 2] = nota3;
                    alumno.GetNotas()[0, 3] = nota4;
                    break;
                case "Martes":
                    alumno.GetNotas()[1, 0] = nota1;
                    alumno.GetNotas()[1, 1] = nota2;
                    alumno.GetNotas()[1, 2] = nota3;
                    alumno.GetNotas()[1, 3] = nota4;
                    break;
                case "Miércoles":
                    alumno.GetNotas()[2, 0] = nota1;
                    alumno.GetNotas()[2, 1] = nota2;
                    alumno.GetNotas()[2, 2] = nota3;
                    alumno.GetNotas()[2, 3] = nota4;
                    break;
                case "Jueves":
                    alumno.GetNotas()[3, 0] = nota1;
                    alumno.GetNotas()[3, 1] = nota2;
                    alumno.GetNotas()[3, 2] = nota3;
                    alumno.GetNotas()[3, 3] = nota4;
                    break;
                case "Viernes":
                    alumno.GetNotas()[4, 0] = nota1;
                    alumno.GetNotas()[4, 1] = nota2;
                    alumno.GetNotas()[4, 2] = nota3;
                    alumno.GetNotas()[4, 3] = nota4;
                    break;
                default:
                    break;
            }
            alumno.calcPromedio();

            OnPropertyChanged(nameof(alumno));

            AppData.maestroInicial.materiaInicial.alumnoSeleccionado = this.alumno;

            AppData.maestroInicial.materiaInicial.ActualizarAlumnoMateria(this.alumno);

            AppData.maestroInicial.ActualizarMateriaMaestro(AppData.maestroInicial.materiaInicial);
        }


        #endregion

        #region COMANDOS
        public ICommand CalcNotaCommand => new Command(async () =>
        {
            await GuardarNotas();
        });
        #endregion

    }
    }

