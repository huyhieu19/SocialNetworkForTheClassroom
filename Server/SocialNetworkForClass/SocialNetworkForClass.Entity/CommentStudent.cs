using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CommentStudent
    {
        public int id { get; set; }
        public int commentId { get; set; }
        public int studentId { get; set; }
        public Student student { get; set; }
    }
}
