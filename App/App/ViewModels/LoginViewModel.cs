using System;
using System.Collections.Generic;
using System.Text;

namespace App.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        #region variables
        string email;
        string password;
        bool isrunning;

        #endregion
        #region propiedades
        public string Email {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        #endregion
    }
}
