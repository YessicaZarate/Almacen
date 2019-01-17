using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Almacén.Models
{
    public class Branches
    {
        [Key]
        public int BranchId { get; set; }

        public string BranchName { get; set; }

        public string City { get; set; }

        public int LocId { get; set; }

        public int ProdId { get; set; }

        [ForeignKey("LocId")]
        public virtual Locations Locations { get; set; }

        [ForeignKey("ProdId")]
        public virtual Products Products { get; set; }
    }
}