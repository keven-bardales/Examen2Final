using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class ClaseDiaSemana : Materia, IClase
    {
        public void CalcHorasClase()
        {
            base.Duracion = 1;
        }



        public override void setTipoMateria()
        {
            tipoMateria = "Dias De Semana";
        }

        public override string tipoClase()
        {
            return $"Clase Dias de Semana";
        }
    }
}
