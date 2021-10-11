using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }  
       

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
