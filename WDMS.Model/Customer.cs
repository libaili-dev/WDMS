using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDMS.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public int CustomerType { get; set; }

        public string CustomerName { get; set; }

        public int Gender { get; set; }

        public string MobileNumber { get; set; }

        public DateTime FittingDate { get; set; }

        public DateTime FinalFittingDate { get; set; }

        public DateTime WeddingDate { get; set; }

        public DateTime CreateTime { get; set; }

        public int Operator { get; set; }

    }


    public class CustomerType
    {
        public int CustomerTypeId { get; set; }

        public string CustomerTypeName { get; set; }

        public float Discount { get; set; }


    }

}
