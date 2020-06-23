using System;
namespace WebAssemblySample.Fish
{
    public class GPS
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public GPS()
        {

        }

        public override string ToString()
        {
            return Latitude + "," + Longitude;
        }
    }
}
