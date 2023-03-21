using Examen2Progra2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen2Progra2.ViewModel;
namespace Examen2Progra2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewAlumno : ContentPage
    {
        public ViewAlumno(Alumno alumno)
        {
            InitializeComponent();
            BindingContext = new ViewModelAlumno(Navigation, alumno);
        }
    }
}