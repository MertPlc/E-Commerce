using ApplicationLayer.Entities.Concrete;
using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete.EF
{
    public class EfAddressDAL : EfEntityRepositoryBase<Address, ECommerceContext>
    {
    }
}
