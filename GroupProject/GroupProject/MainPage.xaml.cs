﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroupProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void playButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }



        private void CrimePictureButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new startPage());
        }
    }
}
