using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuessTheYearApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class P2Q1 : ContentPage
    {
        public P2Q1()
        {
            InitializeComponent();

            image1.Source = ImageSource.FromResource("GuessTheYearApp.Images.Period2.jfk.jpg");
        }

        private void Button_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1W());
        }

        private void Button_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1W());
        }

        private void Button_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P2Q1C());
        }

        private void Button_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1W());
        }
    }
}