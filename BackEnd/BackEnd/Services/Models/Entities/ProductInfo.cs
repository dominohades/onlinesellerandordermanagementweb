using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class ProductInfo
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public int ProductPrice { get; set; }

        public string ProductQuantity { get; set; }

        public string ProductDescription { get; set; }

        public int ProductSubtotal { get; set; }

        public string ProductCategory { get; set; }

        public string ProductCategoryPart { get; set; }
    }
}
