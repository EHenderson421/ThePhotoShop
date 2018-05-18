using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThePhotoShop5.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Display(Name = "Name of Location")]
        public string NameOfLocation { get; set; }

        [Display(Name = "Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        public string Zip { get; set; }


    }
}