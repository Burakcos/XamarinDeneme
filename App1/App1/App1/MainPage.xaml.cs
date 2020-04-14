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
            slider.Value = 0.5;
          
        }

        int count = 0;
        void Handle_Click(object sender,EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            btn.Text = $"butona {count} kez tıklandı.";

        }

        void Handle_Slider(object sender,Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);

        }
    }
}
