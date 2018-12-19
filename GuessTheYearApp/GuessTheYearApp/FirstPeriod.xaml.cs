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
	public partial class FirstPeriod : ContentPage
	{
		public FirstPeriod ()
		{
			InitializeComponent ();

            image1.Source = ImageSource.FromResource("GuessTheYearApp.Images.PeriodOne.ww2.jpg");
        }

        private void Button_Begin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1Q1());
        }
    }
}