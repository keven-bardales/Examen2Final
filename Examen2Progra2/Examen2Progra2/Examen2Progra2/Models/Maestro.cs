using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.Shapes;

namespace Examen2Progra2.Models
{
    [Serializable]
    public  class Maestro
    {
        public ObservableCollection<Materia> listaClases { get; set; } = new ObservableCollection<Materia>();

        public Materia materiaInicial { get; set; }
        public string nombreMaestro { get; set; }
        private const float SALARIO_POR_HORA = 120;
        private double salario;

        public int totalHorasTrabajadas { get; set; }

        public Cuenta cuentaMaestro { get; set; }

        public double getSalario()
        {
            return this.salario;
        }

        public void ActualizarMateriaMaestro(Materia nuevaMateria)
        {
            foreach (Materia materia in listaClases)
            {
                if (materia.faseClase == nuevaMateria.faseClase && materia.semanaClase == nuevaMateria.semanaClase)
                {
                    materia.ActualizarMateria(nuevaMateria);
                    break;
                }
            }
        }



        public void calcSalario()
        {
            this.salario = SALARIO_POR_HORA * totalHorasTrabajadas;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nNombre del maestro: {nombreMaestro}");
            sb.AppendLine("Materias que imparte:");
            foreach (Materia materia in listaClases)
            {

                sb.AppendLine($"- Fase: {materia.faseClase}\tSemana: {materia.semanaClase} \tTipo de Clase: {materia.tipoClase()} \tDuracion: {materia.Duracion}");

            }
            sb.AppendLine($"Horas trabajadas: {totalHorasTrabajadas}");
            return sb.ToString();
        }

        public string listarAlumnosClase(Materia materia)
        {
            return materia.listarAlumnos();
        }

    }
}
