﻿using System.ComponentModel.DataAnnotations;

namespace hotel_listing_api.Models.Country
{
    public abstract class BaseCountryDTO
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
