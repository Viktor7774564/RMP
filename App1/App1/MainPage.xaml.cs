using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MainPage mainPage = new MainPage();
            Image image = new Image();
            Entry login = new Entry();
            Entry password = new Entry();
            Button button = new Button();
            image.Source = "Facebook.png";
            string BMainColor = "#32B898";
            string BButtonColor = "#4A799A";
         
            login.BackgroundColor = Color.White;
            password.BackgroundColor = Color.White;
            button.BackgroundColor = Color.FromHex(BButtonColor);
            button.Clicked += regClick;
        }

        private async void regClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
