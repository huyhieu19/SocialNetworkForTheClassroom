using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityBase
    {
        public bool IsDelete { get; set; } = false;
        public DateTime DateCreate { get; set; } = DateTime.Now;
        public DateTime DateDelete { get; set; }
        public string UserCreate { get; set; } = "Huy Hieu";

    }
}
