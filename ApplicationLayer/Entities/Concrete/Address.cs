using ApplicationLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string AddressName { get; set; } // Work, Home etc.
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
