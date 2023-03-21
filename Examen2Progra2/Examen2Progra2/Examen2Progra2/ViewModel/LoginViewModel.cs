using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Examen2Progra2.Models;

namespace Examen2Progra2.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string usuario;
        private string password;

        public string Usuario
        {
            get => usuario;
            set
            {
                usuario = value;
                if(usuario != null)
                {
                    usuario += value;
                    OnPropertyChanged(nameof(usuario));
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                if (password != null)
                {
                    password = value;
                    OnPropertyChanged(nameof(password));
                }
            }
        }


        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        private void OnLogin()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
