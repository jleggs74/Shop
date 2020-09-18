namespace Shop.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Shop.UIForms.Views;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel 
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand 
        {
            get
            {
                return new RelayCommand(Login);
            } 
        }

        public LoginViewModel()
        {
            this.Email = "jllg74@gmail.com";
            this.Password = "Siggel";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email)) 
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must Enter an Email ...",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must Enter a Valid Password ...",
                    "Accept");
                return;
            }

            if (!this.Email.Equals("jllg74@gmail.com") || !this.Password.Equals("Siggel")) 
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "User or Password Wrong ...",
                    "Accept");
                return;
            }

            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Ok",
            //    "Fuck You !!!",
            //    "Accept");

        }
    }
}
