﻿using System.ComponentModel.DataAnnotations;

namespace hotel_listing_api.Models.Hotels
{
    public abstract class BaseHotelDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Address { get; set; }

        public double? Rating { get; set; }
        
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
