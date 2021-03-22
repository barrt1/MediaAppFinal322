using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MediaAppFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }


        async private void Button_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new LoginPage());
        }
        async private void Button_Clicked1(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Movies());
        }
        async private void Button_Clicked2(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Tvshows());
        }
        async private void Button_Clicked3(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Games());
        }
    }
}