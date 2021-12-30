using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace visitors.Models
{
    public class Visitor
    {
        public string supplierName { get; set; }
        public string driverName { get; set; }
        public string IDNumber { get; set; }
        public string vehicleType { get; set; }
        public string plateNumber { get; set; }
        public string destination { get; set; }
        public string entryDate { get; set; }
        public string entryTime { get; set; }
        public string  exitDate { get; set; }
        public string exitTime { get; set; }
        public bool isVisitor { get; set; }
    }
}