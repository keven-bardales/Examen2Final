using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class AlumnoDiasDeSemana : Alumno
    {
        double[,] notas = new double[5, 4];

        public void SetNotas(double[,] nuevasNotas)
        {
            notas = nuevasNotas;
        }

        public double[,] GetNotas()
        {
            return notas;
        }



        public override void calcPromedio()
        {
            double suma = 0;
            int contador = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    suma += notas[i, j];
                    contador++;
                }
            }



            base.promedio = suma / contador;
        }


        public AlumnoDiasDeSemana()
        {
            tipoAlumno = 1;
        }






    }
}
