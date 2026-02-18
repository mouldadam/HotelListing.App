namespace HotelListing.Api.Data;

public class Country
{
    public int CountryId { get; set; }
    public required string Name { get; set; }
    public required string ShortNam { get; set; }
    public IList<Hotel> Hotels { get; set; } = [];
}
