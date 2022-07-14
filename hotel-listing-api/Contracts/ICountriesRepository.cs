using hotel_listing_api.Data;

namespace hotel_listing_api.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
