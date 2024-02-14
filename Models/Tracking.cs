namespace ShipAndTrack.Models
{
public class Tracking
{
    public int ID { get; set; }
    public DateTime CreatedAt {get;set;}
    public string Status { get; set;}
    public int PackageID {get;set;}

    public Package Package {get;set;}
}
}