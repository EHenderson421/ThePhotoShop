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
        public string LocationId { get; set; }
        public string NameOfLocation { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


    }
}