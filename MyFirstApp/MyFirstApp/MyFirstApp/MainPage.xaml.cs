﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Ok Button Clicked!", "", "Ok");
        }
    }
}
