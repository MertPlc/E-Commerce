using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; } 
        public string ImagePath { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
