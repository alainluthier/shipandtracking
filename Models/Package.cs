namespace ShipAndTrack.Models
{
    public class Package
    {
        public int ID { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string TrackingNumber { get; set; }
        public string Description {get;set;}
        public int UserID { get; set; }
        public User User { get; set; }
        public int AddressID {get;set;}
        public Address Address {get;set;}
        public ICollection<Tracking> Trackings { get; set; }
    }

}
