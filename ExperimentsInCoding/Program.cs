using System;

namespace ExperimentsInCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var latLng = LattitudeLongitude.GetLattitudeLongitude(lattitude: "47.730667", longitude: "-122.218755");
            Console.WriteLine($"Lattude is {latLng.lattitude}, Longitude is {latLng.longitude}");
            Console.Read();
        }
    }
}
