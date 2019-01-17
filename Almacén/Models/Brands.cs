using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Almacén.Models
{
    public class Brands
    {
        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public int LocId { get; set; }

        [ForeignKey("LocId")]
        public virtual Locations Locations { get; set; }
    }
}