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
	public partial class SecondPeriod : ContentPage
	{
		public SecondPeriod ()
		{
			InitializeComponent ();

            image1.Source = ImageSource.FromResource("GuessTheYearApp.Images.Period2.80.jpg");
        }

        private void Button_Begin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P2Q1());
        }
    }
}