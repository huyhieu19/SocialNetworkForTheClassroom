using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Comment : EntityBase
    {
        public int id { get; set; }
        public int commentId { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public List<CommentStudent> commentStudents { get; set; }
        public List<CommentTeacher> commentTeachers { get; set; }
    }
}
