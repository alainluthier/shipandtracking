namespace ShipAndTrack;
public class Package
{
    public int Id { get; set; }    
    public Address Address { get; set; } = new Address();
    
    public decimal Lenght { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public decimal Weight { get; set; }
}

public class Address
{
    public int Id { get; set; }

    public string Recipient { get; set; }

    public string Street { get; set; }

    //public string Line2 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }
    public string Country { get; set; }
}