﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Documents : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string DocumentUrL { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
