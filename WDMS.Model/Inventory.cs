using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDMS.Model
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        public int StyleId { get; set; }

        public string Size { get; set; }

        public int TotalCount { get; set; }

        public int RentingCount { get; set; }

        public int WashingCount { get; set; }

        public string Status { get; set; }

        public decimal RentPrice { get; set; }

        public decimal SellPrice { get; set; }

        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Operator { get; set; }

    }
}
