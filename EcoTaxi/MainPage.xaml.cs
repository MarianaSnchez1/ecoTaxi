using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EcoTaxi.Class;

namespace EcoTaxi
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public GeoLocation _GeoLocation = new GeoLocation();
        public MainPage()
        {
            InitializeComponent();
            moveToActualPosition();
            
        }

        void moveToActualPosition()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await _GeoLocation.getLocationGPS();
            });
        }
    }
}
