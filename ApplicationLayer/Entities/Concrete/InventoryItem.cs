using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class InventoryItem : IEntity
    {

        public int Id { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

    }
}
