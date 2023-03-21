using Examen2Progra2.Models;
using Examen2Progra2.Views;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Examen2Progra2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "academia.aut");
            if (File.Exists(ruta))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
                if (archivo.Length == 0)
                {
                    archivo.Close();
                    AppData.LoadData();
                }
                else
                {
                    AppData.maestroInicial = (Maestro)formatter.Deserialize(archivo);
                    archivo.Close();
                }
            }
            else
            {
                AppData.LoadData();
            }




        }

        protected override void OnStart()
        {


            MainPage = new NavigationPage(new ViewMaestro());


        }

        protected override void OnSleep()
        {

            Maestro maestroguardar = new Maestro();
            maestroguardar = AppData.maestroInicial;
            BinaryFormatter formatter = new BinaryFormatter();
            string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "academia.aut");
            Stream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(archivo, maestroguardar);
            archivo.Close();

        }

          protected override void OnResume()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "academia.aut");
            if (File.Exists(ruta))
            {
                Stream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
                AppData.maestroInicial = (Maestro)formatter.Deserialize(archivo);
                archivo.Close();
            }
        }
    }

    }


