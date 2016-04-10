using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDMS.Model
{
    public class OrderDetails
    {
        public int OrderDetailId { get; set; }

        public int OrderBatchId { get; set; }

        public string OrderType { get; set; }

        public int InventoryId { get; set; }

        public string DeliveryWay { get; set; }

        public string ExpressionNo { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; }

        public int Operator { get; set; }

        public string Remark { get; set; }

    }
}
