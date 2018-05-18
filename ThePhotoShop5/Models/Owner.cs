using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThePhotoShop5.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
