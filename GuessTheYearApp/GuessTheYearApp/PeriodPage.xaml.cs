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
	public partial class PeriodPage : ContentPage
	{
		public PeriodPage ()
		{
			InitializeComponent ();

            image1.Source = ImageSource.FromResource("GuessTheYearApp.Images.PeriodOne.year.jpg");
        }

        private void Button_50(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FirstPeriod());
        }

        private void Button_99(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPeriod());
        }

        private void Button_20(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThirdPeriod());
        }

    }
}