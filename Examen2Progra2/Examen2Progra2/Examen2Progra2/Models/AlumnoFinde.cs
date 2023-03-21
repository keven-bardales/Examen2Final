using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class AlumnoFinde : Alumno
    {
        private double[] notas = new double[4];

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }


        public double[] GetNotas()
        {
            return notas;
        }


        public override void calcPromedio()
        {

            double suma = 0;

            foreach (double i in notas)
            {
                suma += i;

            }

            base.promedio = suma / notas.Length;

        }

        public AlumnoFinde()
        {
            tipoAlumno = 2;
        }
    }
}
