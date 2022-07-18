using AutoMapper;
using hotel_listing_api.Data;
using hotel_listing_api.Models.Country;
using hotel_listing_api.Models.Hotels;
using hotel_listing_api.Models.Users;

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

            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();

            CreateMap<Hotel, UpdateHotelDTO>().ReverseMap();

            CreateMap<UserDTO, User>().ReverseMap();
        }
    }
}
