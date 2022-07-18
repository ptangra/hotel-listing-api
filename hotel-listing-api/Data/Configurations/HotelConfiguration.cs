using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotel_listing_api.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Beach Resort",
                    Address = "Sunny Beach",
                    Rating = 3.2,
                    CountryId = 1,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Serbian Spa",
                    Address = "Belgrade",
                    Rating = 4.5,
                    CountryId = 2,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Russian Banya",
                    Address = "St. Petersburg",
                    Rating = 5.0,
                    CountryId = 3,
                }
            );
        }
    }
}
