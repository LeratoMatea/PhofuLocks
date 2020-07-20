using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PhofuLocks.Models
{
    public class CarsClass
    {
        [Key]
        public int OrderID{ get; set; }
        public int CarID { get; set; }
        public string Transmission { get; set; }
        public string CarModel { get; set; }
        public string CarMake { get; set; }
        public int Quantity { get; set; }

    }
}
