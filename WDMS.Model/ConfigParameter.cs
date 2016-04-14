﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDMS.Model
{
    public class ConfigParameter
    {
        public int ConfigId { get; set; }

        public string ConfigKey { get; set; }

        public string ConfigValue { get; set; }

        public string ConfigGroup { get; set; }

        public string Description { get; set; }
    }
}
