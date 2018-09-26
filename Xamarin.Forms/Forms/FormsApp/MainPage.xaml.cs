using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Handle_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("App Name", "Span Action", "Ok");
        }
    }
}
