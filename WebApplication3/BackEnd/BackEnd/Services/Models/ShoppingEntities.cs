using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BackEnd.Services.Models.Entities
{
    public class ShoppingEntities: DbContext
    {
        public ShoppingEntities() : base("ShoppingDB") { }

        public IDbSet<CustomerInfo> custInfo { get; set; }
        public IDbSet<ProductInfo> prodInfo { get; set; }


    }
}
