using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace EcoTaxi.Class
{
    public class GeoLocation
    {
        public static double lat { get; set; }
        public static double lng { get; set; }

        public async Task  getLocationGPS()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Best);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    lat = location.Latitude;
                    lng = location.Longitude;
                }
                else
                {
                    var knowLocation = await Geolocation.GetLastKnownLocationAsync();
                    lat = knowLocation.Latitude;
                    lng = knowLocation.Longitude;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }

    }
}
