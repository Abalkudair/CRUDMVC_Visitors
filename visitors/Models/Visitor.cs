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
        [MinLength(10, ErrorMessage = "Min 10"), MaxLength(10, ErrorMessage = "Max 10")]
        public string IDNumber { get; set; }
        [Display(Name = "Vehicle Type")]
        [Required]
        public TypeofVehicles vehicleType { get; set; }

        [Display(Name = "Plate Number")]
        [Required]
        [MinLength(4, ErrorMessage = "Min 4"), MaxLength(4, ErrorMessage = "Max 4")]
        public string plateNumber { get; set; }
        [Display(Name = "Distination")]

        [Required]
        public string destination { get; set; }
        [Display(Name = "Entry Date")]

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string entryDate { get; set; }
        [Display(Name = "Entry Time")]

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public string entryTime { get; set; }
        [Display(Name = "Exit Date")]

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string exitDate { get; set; }
        [Display(Name = "Exit Time")]

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public string exitTime { get; set; }
        [Display(Name = "Is he Visitor ?")]
        [Required]
        public string isVisitor { get; set; }
    }
}