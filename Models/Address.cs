namespace ShipAndTrack.Models
{
    public class Address
    {
        public int ID { get; set; }

        public string Recipient { get; set; }
        public string Phone { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int UserID {get;set;}

        public User User {get;set;}
    }
}