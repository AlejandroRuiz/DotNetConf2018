using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsDemo
{
    public partial class MainPage : ContentPage
    {
        bool isTurnedOn;

        public async void Handle_Clicked2(object sender, EventArgs e)
        {
            try
            {
                if (!isTurnedOn)
                {
                    await Flashlight.TurnOnAsync();
                    isTurnedOn = true;
                }
                else
                {
                    await Flashlight.TurnOffAsync();
                    isTurnedOn = false;
                }
            }
            catch
            {
            }
        }

        public void Handle_Clicked1(object sender, EventArgs e)
        {
            DisplayAlert("Info", $"ChargeLevel: {Battery.ChargeLevel}\nPowerSource: {Battery.PowerSource}\nState: {Battery.State}", "Ok");
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
