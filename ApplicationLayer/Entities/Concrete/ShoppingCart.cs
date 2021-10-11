using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class ShoppingCart :IEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime ExpireOn { get; set; }


        public virtual List<InventoryItem> InventoryItems { get; set; }

    }
}
