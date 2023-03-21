using Examen2Progra2.Models;
using Examen2Progra2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2Progra2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewAddAlumno : ContentPage
	{
		public ViewAddAlumno (Materia materia)
		{
			InitializeComponent ();
			BindingContext = new ViewModelAddAlumno(Navigation, materia);
		}
	}
}