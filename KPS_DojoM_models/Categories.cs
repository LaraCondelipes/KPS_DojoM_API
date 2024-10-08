﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
    public class Categories
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public virtual List<Athletes>? Athlete { get; set; }
        public virtual List<Events>? Event { get; set; }
    }
}
