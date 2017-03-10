using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnhancedFamilyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            lbl0.Text = "00000000";
            lbl1.Text = "11111111";
            lbl2.Text = "22222222";
            lbl3.Text = "33333333";
            lbl4.Text = "44444444";
            lbl5.Text = "55555555";
            lbl6.Text = "66666666";
            lbl7.Text = "77777777";
            lbl8.Text = "88888888";
            lbl9.Text = "99999999";
        }
    }
}
