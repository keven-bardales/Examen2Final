using Examen2Progra2.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen2Progra2.ViewModel;
namespace Examen2Progra2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewMateria : ContentPage
    {
        public ViewMateria(Materia materia)
        {
            InitializeComponent();

             BindingContext = new ViewModelMateria(Navigation, materia);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

          
            CollectionAlumnos.SelectedItem = null;
        }


    }
}