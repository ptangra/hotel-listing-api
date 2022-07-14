using hotel_listing_api.Models.Hotels;

namespace hotel_listing_api.Models.Country
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<HotelDTO> Hotels { get; set; }
    }
}
