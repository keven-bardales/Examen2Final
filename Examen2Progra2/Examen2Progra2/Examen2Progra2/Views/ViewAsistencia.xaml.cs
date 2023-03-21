using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen2Progra2.ViewModel;
using System.Collections.ObjectModel;
using Examen2Progra2.Models;

namespace Examen2Progra2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewAsistencia : ContentPage
	{
		public ViewAsistencia (Materia materia)
		{
			InitializeComponent ();
			BindingContext = new ViewModelAsistencia(Navigation, materia);
		}
	}
}