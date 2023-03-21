using Examen2Progra2.Models;
using Examen2Progra2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2Progra2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewCalcNotaFinde : ContentPage
	{
		public ViewCalcNotaFinde (AlumnoFinde alumnoActual)
		{
			InitializeComponent ();
			BindingContext = new ViewModelCalcNotaFinde(Navigation, alumnoActual);
		}
	}
}