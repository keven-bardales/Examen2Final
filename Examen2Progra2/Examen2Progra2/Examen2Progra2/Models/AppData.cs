using Examen2Progra2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public static class AppData
    {
        public static Academia academiaEuropea;

        public static Maestro maestroInicial;

        public static ObservableCollection<Materia> materiasactuales;

        public static ObservableCollection<Alumno> alumnosactuales;





        public static Materia materiaSeleccionada;

        public static Alumno alumnoSeleccionado;

        

        public static void LoadData()
        {
            academiaEuropea = new Academia();

            maestroInicial = new Maestro();

            maestroInicial = new Maestro()
            {
                nombreMaestro = "Keven Bardales",
                totalHorasTrabajadas = 80
            };

            maestroInicial = new Maestro
            {
                nombreMaestro = "Keven Bardales",
                totalHorasTrabajadas = 80,
                cuentaMaestro = new Cuenta()
                {
                    contraUsuario = "admin",
                    nombreUsuario = "admin"
                },
                //Inicializamos lista del maeastro actual
                listaClases = new ObservableCollection<Materia>()
            };
            //Inicializamos una primera clase de fin de semana
            ClaseFindeSemana ma = new ClaseFindeSemana() { faseClase = 4, semanaClase = 7 };
            ma.CalcHorasClase();
            ma.setTipoMateria();
            //Inicializamos su lista de alumnos
            ma.listaAlumnos = new ObservableCollection<Alumno>();

            // Crear objetos AlumnoFinde y agregarlos a la lista
            AlumnoFinde alumno1 = new AlumnoFinde() { nombreAlumno = "Antonio" };
            ma.listaAlumnos.Add(alumno1);

            AlumnoFinde alumno2 = new AlumnoFinde() { nombreAlumno = "María" };
            ma.listaAlumnos.Add(alumno2);

            AlumnoFinde alumno3 = new AlumnoFinde() { nombreAlumno = "Juan" };
            ma.listaAlumnos.Add(alumno3);

            // Crear más objetos AlumnoFinde y agregarlos a la lista
            AlumnoFinde alumno4 = new AlumnoFinde() { nombreAlumno = "Pedro" };
            ma.listaAlumnos.Add(alumno4);

            AlumnoFinde alumno5 = new AlumnoFinde() { nombreAlumno = "Ana" };
            ma.listaAlumnos.Add(alumno5);
            ma.maestroasignado = maestroInicial;

            maestroInicial.listaClases.Add(ma);

            // Inicializar el resto de los objetos aquí

            // ..

            academiaEuropea.maestroList.Add(maestroInicial);
        }
    }
}
