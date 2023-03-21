using Examen2Progra2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2Progra2.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2Progra2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewCalcDiasSemana : ContentPage
	{
		public ViewCalcDiasSemana (AlumnoDiasDeSemana alumnoActual)
		{
			InitializeComponent ();
			BindingContext = new ViewModelCalcNotaDias(Navigation, alumnoActual);
		}

	}
}