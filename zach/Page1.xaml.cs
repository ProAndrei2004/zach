using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zach
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double slid = slider.Value;
            
            string srok;
            srok = credit.Text;
            double srok1 = Convert.ToDouble(srok);
            double a;

            if(srok1 <= 12)
            {     
                EveryMounthPay.Text = $"{slid / srok1 + slid * 0.059}";
            }
            else if(srok1 > 13 && srok1 <= 24)
            {
                double dogoda = slid / srok1 + slid * 0.059;
                EveryMounthPay.Text = $"{(dogoda + slid) / srok1 + (slid - 6000) * 0.059}";
            }
            else
            {
                double dogoda = slid / srok1 + slid * 0.059;
                EveryMounthPay.Text = $"{(dogoda + slid) / srok1 + (slid - 10000)* 0.042}";
            }



        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}