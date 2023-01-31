using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restory_Restaurant_EntityLayer.Concrete
{
    public class PopularFlavor
    {
        [Key]
        public int PopularFlavorsID { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
