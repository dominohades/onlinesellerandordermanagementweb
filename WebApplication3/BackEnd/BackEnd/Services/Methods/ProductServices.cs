using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Services.Models.Entities;

namespace BackEnd.Services.Methods
{
    public class ProductServices
    {
        private readonly ShoppingEntities shopdb;

        public ProductServices() {
            shopdb = new ShoppingEntities();
        }

        public void Add(ProductInfo prodinfo) {
            shopdb.prodInfo.Add(prodinfo);
            shopdb.SaveChanges();
        }
    }
}
