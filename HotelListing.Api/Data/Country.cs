namespace HotelListing.Api.Data;

public class Country
{
    public int CountryId { get; set; }
    public string Name { get; set; }
    public string ShortNam { get; set; }
    public IList<Hotel>? Hotels { get; set; } = [];
}
