using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restory_Restaurant_EntityLayer.Concrete
{
    public class Introduction
    {
        [Key]
        public int WelcomeID { get; set; }
        public string Title1{ get; set; }
        public string Title2{ get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string ImageUrl { get; set; }
    }
}
