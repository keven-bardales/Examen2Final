using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class Materia
    {

        public Alumno alumnoSeleccionado { get; set; }
        public ObservableCollection<Alumno> listaAlumnos { get; set; } = new ObservableCollection<Alumno>();
        public int faseClase { get; set; }
        public int semanaClase { get; set; }
        public int Duracion { get; set; }

        public string tipoMateria { get; set; }

        public virtual string tipoClase()
        {
            return $"Esta es la clase Padre";
        }

        public virtual void setTipoMateria()
        {
            tipoMateria = "CLASE PADRE";
        }
        
        public Maestro maestroasignado { get; set; }

        public virtual string listarAlumnos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nListado de Alumnos de Clase \nFase: {faseClase} \t Semana Clase: {semanaClase} Maestro: {maestroasignado.nombreMaestro}");
            foreach (Alumno alumno in listaAlumnos)
            {
                sb.AppendLine($"{alumno.ToString()}");
            }

            return sb.ToString();
        }

        public void ActualizarMateria(Materia nuevaMateria)
        {
          
            listaAlumnos = nuevaMateria.listaAlumnos;
            faseClase = nuevaMateria.faseClase;
            semanaClase = nuevaMateria.semanaClase;
            Duracion = nuevaMateria.Duracion;
            tipoMateria = nuevaMateria.tipoMateria;
            maestroasignado = nuevaMateria.maestroasignado;
        }

        public void ActualizarAlumnoMateria(Alumno nuevoAlumno)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.nombreAlumno == nuevoAlumno.nombreAlumno)
                {
                    alumno.ActualizarAlumno(nuevoAlumno);
                    break;
                }
            }
        }


    }
}
