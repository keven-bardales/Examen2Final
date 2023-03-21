using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class ClaseFindeSemana : Materia, IClase
    {
        //Utilizamos la interfaz IClase que tiene el metodo calcHorasClase


        public void CalcHorasClase()
        {
            base.Duracion = 4;

        }

        public override void setTipoMateria()
        {
            tipoMateria = "Fin De Semana";
        }

        public override string tipoClase()
        {
            return $"Clase Fin de Semana";
        }
    }
}
