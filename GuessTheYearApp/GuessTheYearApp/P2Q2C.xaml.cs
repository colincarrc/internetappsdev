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
	public partial class P2Q2C : ContentPage
	{
		public P2Q2C ()
		{
			InitializeComponent ();
		}

        private void Button_Begin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new P2Q3());
        }
    }
}