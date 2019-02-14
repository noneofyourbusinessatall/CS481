using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navigation_attempt
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //myLocalImage.Source = ImageSource.FromFile("fox.png");
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            MainLabel.Text = "Hello " + MainEntry.Text;
            await Navigation.PushAsync( new Page2(MainEntry.Text) );
        }
    }
}
