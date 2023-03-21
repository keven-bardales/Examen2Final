using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Examen2Progra2.Models
{
    [Serializable]
    public class Academia
    {

        public ObservableCollection<Maestro> maestroList { get; set; } = new ObservableCollection<Maestro>();

        public void agregarMaestro(Maestro maestro)
        {
            maestroList.Add(maestro);
        }

        public Maestro inciarSesionMaestro(string nombreUsuario, string contraMaestro)
        {
            foreach (Maestro maestro in maestroList)
            {
                if (maestro.cuentaMaestro.nombreUsuario.Equals(nombreUsuario) && maestro.cuentaMaestro.contraUsuario.Equals(contraMaestro))
                {
                    return maestro;
                }
            }
            return null;
        }

        public int loginGetMaestroActual(string nombreUsuario, string contraMaestro)
        {
            for (int i = 0; i < maestroList.Count; i++)
            {
                if (maestroList.ElementAt(i).cuentaMaestro.nombreUsuario.Equals(nombreUsuario) && maestroList.ElementAt(i).cuentaMaestro.contraUsuario.Equals(contraMaestro))
                {
                    return i;
                }

            }
            return -1;
        }

    }
}
