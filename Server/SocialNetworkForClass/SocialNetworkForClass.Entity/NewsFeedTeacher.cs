using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsFeedTeacher
    {
        public int id { get; set; }
        public int newsFeedId { get; set; }
        public int teacherId { get; set; }
        public Teacher teacher { get; set; }

    }
}
