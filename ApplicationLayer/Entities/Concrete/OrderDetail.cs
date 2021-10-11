using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class OrderDetail : IEntity
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string TotalAmountText => $"{TotalAmount():N2}"; // TODO: it wont map in db

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        private decimal TotalAmount() => Quantity * UnitPrice;




    }
}
