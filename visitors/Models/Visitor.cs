using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace visitors.Models
{
    public class Visitor
    {
        public int Id { get; set; }

        [Display(Name = "Supplier Name")]
        public string supplierName { get; set; }

        [Required]
        [Display(Name = "Driver Name")]
        public string driverName { get; set; }
        [Display(Name = "ID Number")]

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string IDNumber { get; set; }
        [Display(Name = "Vehicle Type")]
        [Required]
        public string vehicleType { get; set; }

        [Display(Name = "Plate Number")]
        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        public string plateNumber { get; set; }
        [Display(Name = "Distination")]

        [Required]
        public string destination { get; set; }
        [Display(Name = "Entry Date")]

        [Required]
        [MaxLength(10)]
        public string entryDate { get; set; }
        [Display(Name = "Entry Time")]

        [Required]
        [MaxLength(5)]
        public string entryTime { get; set; }
        [Display(Name = "Exit Date")]

        [Required]
        [MaxLength(10)]
        public string exitDate { get; set; }
        [Display(Name = "Exit Time")]

        [Required]
        [MaxLength(5)]
        public string exitTime { get; set; }
        [Display(Name = "Is he Visitor ?")]
        [Required]
        public string isVisitor { get; set; }
    }
}