using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zach
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (login.Text != "" && password.Text != "")
            {
                await Navigation.PushAsync(new Page1());
            }
            else
            {
                await DisplayAlert("Внимание", "Поля ввода пустые", "OK");
            }
        }
    }
}
