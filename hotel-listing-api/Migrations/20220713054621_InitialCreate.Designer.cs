// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hotel_listing_api.Data;

#nullable disable

namespace hotel_listing_api.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20220713054621_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("hotel_listing_api.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bulgaria",
                            ShortName = "BG"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Serbia",
                            ShortName = "SR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Russia",
                            ShortName = "RU"
                        });
                });

            modelBuilder.Entity("hotel_listing_api.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sunny Beach",
                            CountryId = 1,
                            Name = "Beach Resort",
                            Rating = 3.2000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Address = "Belgrade",
                            CountryId = 2,
                            Name = "Serbian Spa",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "St. Petersburg",
                            CountryId = 3,
                            Name = "Russian Banya",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("hotel_listing_api.Data.Hotel", b =>
                {
                    b.HasOne("hotel_listing_api.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("hotel_listing_api.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
