﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuessTheYearApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class P2Q4 : ContentPage
	{
		public P2Q4 ()
		{
			InitializeComponent ();

            image1.Source = ImageSource.FromResource("GuessTheYearApp.Images.Period2.albert-einstein.jpg");
        }

        private void Button_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P2Q4C());
        }

        private void Button_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1W());
        }

        private void Button_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1W());
        }

        private void Button_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P1W());
        }
    }
}