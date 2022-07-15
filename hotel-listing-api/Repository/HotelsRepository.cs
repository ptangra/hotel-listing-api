using hotel_listing_api.Contracts;
using hotel_listing_api.Data;

namespace hotel_listing_api.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }


    }
}
