﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }
        public string TypeName { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
