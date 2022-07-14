using AutoMapper;
using hotel_listing_api.Data;
using hotel_listing_api.Models.Country;
using hotel_listing_api.Models.Hotels;

namespace hotel_listing_api.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDTO>().ReverseMap();

            CreateMap<Country, GetCountryDTO>().ReverseMap();

            CreateMap<Country, CountryDTO>().ReverseMap();

            CreateMap<Country, UpdateCountryDTO>().ReverseMap();

            CreateMap<Hotel, HotelDTO>().ReverseMap();
        }
    }
}
