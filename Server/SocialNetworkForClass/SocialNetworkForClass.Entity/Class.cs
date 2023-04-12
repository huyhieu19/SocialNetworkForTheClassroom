using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Class : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public int teacherId { get; set; }
        public string description { get; set; } = string.Empty;
        public Teacher teacher { get; set;}
        public List<Document> documents { get; set; }
        public List<Score> scores { get; set; }
    }
}
