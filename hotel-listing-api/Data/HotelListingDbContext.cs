using Microsoft.EntityFrameworkCore;

namespace hotel_listing_api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Bulgaria",
                    ShortName = "BG"
                },
                new Country
                {
                    Id = 2,
                    Name = "Serbia",
                    ShortName = "SR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Russia",
                    ShortName = "RU"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
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
