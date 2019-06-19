using System.Runtime.Serialization;

namespace AbcComponentsHelper.TimePicker
{
    [DataContract]
    public class Location
    {
        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        [DataMember(Name = "radius")]
        public double Radius { get; set; }

        [DataMember(Name = "title")]
        public double Title { get; set; }

        public Location(double latitude, double longitude, double radius, double title)
        {
            Latitude = latitude;
            Longitude = longitude;
            Radius = radius;
            Title = title;
        }
    }
}