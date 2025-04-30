using Newtonsoft.Json;
using System;
using System.Net;

public class GeoInfo
{
    public float lat { get; set; }
    public float lon { get; set; }
}

public static class LocationService
{
    public static bool IsWithinKAURadius()
    {
        try
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString("http://ip-api.com/json/");
                GeoInfo userLocation = JsonConvert.DeserializeObject<GeoInfo>(json);

                double userLat = userLocation.lat;
                double userLon = userLocation.lon;

                // KAU central location
                double kauLat = 21.4933;
                double kauLon = 39.2458;

                // Get distance in meters
                double distanceInMeters = GetDistanceInKm(userLat, userLon, kauLat, kauLon) * 1000;

                // Compare to 6200 meters (6.5 km)
                return distanceInMeters <= 6200;
            }
        }
        catch
        {
            return false;
        }
    }

    // Calculates distance in kilometers
    private static double GetDistanceInKm(double lat1, double lon1, double lat2, double lon2)
    {
        const double R = 6371.0; // Radius of the Earth in km
        double dLat = DegreesToRadians(lat2 - lat1);
        double dLon = DegreesToRadians(lon2 - lon1);

        double a =
            Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) *
            Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c; // returns distance in kilometers
    }

    private static double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }

    public static string GetRawLocation()
    {
        try
        {
            using (WebClient wc = new WebClient())
            {
                return wc.DownloadString("http://ip-api.com/json/");
            }
        }
        catch
        {
            return "Error getting location.";
        }
    }
}

    private static double DegreesToRadians(double deg)
    {
        return deg * (Math.PI / 180);
    }
}
