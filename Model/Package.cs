namespace ShipAndTrack;
public class Package
{
    public int Id { get; set; }
    public Address Address { get; set; } = new Address();

    public decimal Length { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public decimal Weight { get; set; }
}
