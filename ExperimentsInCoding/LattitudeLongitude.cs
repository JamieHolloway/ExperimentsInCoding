using System;

namespace ExperimentsInCoding
{
    internal class LattitudeLongitude
    {
        public static (double lattitude, double longitude) GetLattitudeLongitude(string lattitude, string longitude)
        {
            var latLng = (lattitude: 0.0, longitude: 0.0);
            latLng.lattitude = Convert.ToDouble(lattitude);
            latLng.longitude = Convert.ToDouble(longitude);
            return latLng;
        }
    }
}
