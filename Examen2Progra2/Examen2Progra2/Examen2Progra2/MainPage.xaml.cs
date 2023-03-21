using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Examen2Progra2.ViewModel;
using Examen2Progra2.Models;
using System.Collections.ObjectModel;

namespace Examen2Progra2
{
    public partial class MainPage : TabbedPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            AppData.LoadData();
        }

      
    }
}
