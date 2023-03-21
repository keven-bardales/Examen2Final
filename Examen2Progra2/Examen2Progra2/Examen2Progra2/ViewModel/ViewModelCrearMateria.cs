using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Examen2Progra2.Models;
using Examen2Progra2.Views;
using Xamarin.Forms;

namespace Examen2Progra2.ViewModel
{
    public  class ViewModelCrearMateria: BaseViewModel
    {
        #region VARIABLES
        private string tipoMateria;
        private int semanaClase;
        private int faseClase;


        #endregion

        #region CONSTRUCTOR
        public ViewModelCrearMateria(INavigation navigation) {

            Navigation = navigation;
        }

        #endregion

        #region OBJETOS

        public string TipoMateria
        {
            get { return tipoMateria; }
            set { SetValue(ref tipoMateria, value); }
        }
        
        public int SemanaClase
        {
            get { return semanaClase;}
            set { SetValue (ref semanaClase, value);}
        }

        public int FaseClase
        {
            get { return faseClase;}
            set { SetValue(ref faseClase, value); }
        }

        #endregion

        #region PROCESOS
        public async void CrearMateria()
        {
            if(tipoMateria == "Materia Fin De Semana")
            {
                ClaseFindeSemana ma = new ClaseFindeSemana()
                {
                    semanaClase = this.semanaClase,
                    faseClase = this.faseClase,
                    maestroasignado = AppData.maestroInicial
                };
                ma.setTipoMateria();

                AppData.maestroInicial.listaClases.Add(ma);

              
            }else if(tipoMateria == "Materia Dia De Semana")
            {
                ClaseDiaSemana ma = new ClaseDiaSemana()
                {
                    semanaClase = this.semanaClase,
                    faseClase = this.faseClase,
                    maestroasignado = AppData.maestroInicial
                };

                ma.setTipoMateria();
                AppData.maestroInicial.listaClases.Add(ma);
            }

           
        }

       
        #endregion

        #region COMANDOS

        public ICommand CrearMateriaCommand => new Command(CrearMateria);

        #endregion


    }
}
