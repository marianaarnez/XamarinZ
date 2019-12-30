using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        #region variables
        string email;
        string password;
        bool isrunning;
        bool isenabled;
        #endregion
        #region propiedades
        public string Email {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }

        public bool IsEnabled
        {
            get { return this.isenabled; }
            set { SetValue(ref this.isenabled, value); }
        }
        #endregion

        #region comandos
        public ICommand LoginCommand {
            get {
                return new RelayCommand(cmdLogin);
            }  
        }

        private async void cmdLogin()
        {
            if (string.IsNullOrEmpty(Email))
            {
               await App.Current.MainPage.DisplayAlert("Email empty","Please enter your email","Accept");
               return;
            }

            if (string.IsNullorEmpty(Password))
            {
                await App.Current.Mainpage.DisplayAlert("Password emprty", " Please enter password", "Accept");
                return;
            }
            Isrunning = true;
        }
        #endregion
        
      

    }
}
