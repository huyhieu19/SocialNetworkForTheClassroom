using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Document : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int classId { get; set; }
        public string documentUrL { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public Class @class { get; set; }
    }
}
