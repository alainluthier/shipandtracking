using ShipAndTrack.Components.Pages;

namespace ShipAndTrack;
public class Package
{
    public int Id { get; set; }    
    public Address Address { get; set; } = new Address();
    
    public decimal Lenght { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public decimal Weight { get; set; }
    public string TrackingNumber { get; set; }
    public int UserId { get; set; }
    public Tracking[] Trackings { get; set; }
}
