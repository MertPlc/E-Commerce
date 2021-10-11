using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class Order:IEntity
    {

        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }  // TODO : May be it can controls with Enums

        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
