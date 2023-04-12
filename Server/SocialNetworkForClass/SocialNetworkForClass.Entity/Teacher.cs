using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Teacher : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public List<Class> classes { get; set; }
        public List<CommentTeacher> commentTeachers { get; set; }
    }
}
