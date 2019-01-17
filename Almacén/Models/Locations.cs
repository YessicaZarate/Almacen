using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Almacén.Models
{
    public class Locations
    {
        [Key]
        public int LocId { get; set; }

        public string LocName { get; set; }

        public string Notes { get; set; }
    }
}