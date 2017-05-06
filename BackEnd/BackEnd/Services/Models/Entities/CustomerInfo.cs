using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Models.Entities
{
    public class CustomerInfo
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string CustomerEmailAdd { get; set; }

        public int CustomerContact { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPaymentOption { get; set; }

        public string CustomerPendingApproved { get; set; }

        public string CustomerOrderDate { get; set; }

        public string CustomerOrderTime { get; set; }

    }
}
