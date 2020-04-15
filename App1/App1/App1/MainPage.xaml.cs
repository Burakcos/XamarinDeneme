using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //slider.Value = 0.5;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 40, 0, 0);
                    break;
                case Device.Android:
                    this.Padding = new Thickness(0, 10, 0, 0);
                    break;
                default:
                    break;
            }
             this.BackgroundColor= Color.FromHex("00bcd4");

            label1.Text = "Purki App";
            label1.TextColor =Color.White;

            label2.Text = "Hoşgeldin çiçek gibi uygulamaya Çakalll";
            label2.TextColor =Color.White;

            Button1.Text = "Login";
            Button1.TextColor = Color.White;
            Button1.BackgroundColor= Color.FromHex("#dd2c00");

            Button2.Text = "Kayıt";
            Button2.TextColor = Color.White;
            Button2.BackgroundColor = Color.FromHex("#dd2c00");
        }
        
        //int count = 0;
        //void Handle_Click(object sender,EventArgs e)
        //{
        //    count++;
        //    var btn = (Button)sender;
        //    btn.Text = $"butona {count} kez tıklandı.";

        //}

        //void Handle_Slider(object sender,Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);

        //}
    }
}
