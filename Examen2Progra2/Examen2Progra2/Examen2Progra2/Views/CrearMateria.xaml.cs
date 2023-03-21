using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen2Progra2.ViewModel;
using Examen2Progra2.Models;
using Examen2Progra2.Views;

namespace Examen2Progra2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearMateria : ContentPage
    {
        public CrearMateria()
        {
            InitializeComponent();
            BindingContext = new ViewModelCrearMateria(Navigation);
        }
    }
}