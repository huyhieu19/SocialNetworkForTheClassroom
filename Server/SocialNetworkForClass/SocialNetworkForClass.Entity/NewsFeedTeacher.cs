using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsFeedTeacher
    {
        public int Id { get; set; }
        public int NewsFeedId { get; set; }
        public int TeacherId { get; set; }
    }
}
