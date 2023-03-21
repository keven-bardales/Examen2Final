using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Examen2Progra2.ViewModel;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class Alumno : BaseViewModel
    {

        public string nombreAlumno { get; set; }

        public double promedio { get; set; }

        public List<bool> Asistencias { get; set; } = new List<bool>();
        public bool presente { get; set; }

        public int AsistenciasCount => Asistencias.Count(a => a == true);
        public int InasistenciasCount => Asistencias.Count(a => a == false);

        public int tipoAlumno { get; set; }

        public virtual void calcPromedio()
        {
            
        }

        public void registrarAsistencia(bool presente)
        {
            Asistencias.Add(presente);
        }

        public override string ToString()
        {

            return $"\nNombre del alumno: {nombreAlumno}, Promedio: {promedio}";
        }

        public void ActualizarAlumno(Alumno nuevoAlumno)
        {
            this.nombreAlumno = nuevoAlumno.nombreAlumno;
            this.promedio = nuevoAlumno.promedio;
            this.Asistencias = nuevoAlumno.Asistencias;
            this.tipoAlumno = nuevoAlumno.tipoAlumno;
        }


    }



}
