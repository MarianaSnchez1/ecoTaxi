using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace EcoTaxi.Class
{
    public class NetworkState
    {
        public static bool isConnect = false;

        public void iHaveInternet()
        {
            NetworkAccess current = Connectivity.NetworkAccess;
            determinateState(current);

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            determinateState(e.NetworkAccess);
        }

        public void determinateState(NetworkAccess state)
        {
            if (state == NetworkAccess.Internet)
            {
                isConnect = true;
            }
            else if (state == NetworkAccess.Local)
            {
                isConnect = true;
            }
            else if (state == NetworkAccess.ConstrainedInternet)
            {
                isConnect = false;
            }
            else
            {
                isConnect = false;
            }
        }

    }
}
