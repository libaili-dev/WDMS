
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDMS.Model
{
    public class Order
    {
        public int OrderBatchId { get; set; }

        public int  CustomerId { get; set; }

        public string Status { get; set; }

        public int Operator { get; set; }

        public int Assistant { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

    }
}
