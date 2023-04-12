using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ChatGroup : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<ChatGroupStudent> chatGroupStudents { get; set; }
        public List<ChatGroupTeacher> chatGroupTeachers { get; set; }
    }
}
