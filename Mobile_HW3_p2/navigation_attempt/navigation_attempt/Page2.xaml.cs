using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navigation_attempt
{
    public partial class Page2 : ContentPage
    {
        public Page2(string parameter)
        {
            InitializeComponent();
            MainLabel.Text = parameter;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync( new Page3() );
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
