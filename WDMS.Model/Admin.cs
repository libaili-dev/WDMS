using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDMS.Model
{
    public class Admin
    {
        public int AdminId { get; set; }

        public int AdminRoleId { get; set; }

        public string AdminName { get; set; }

        public string Password { get; set; }

        public string AdminRoleAuthority { get; set; }
    }
}
