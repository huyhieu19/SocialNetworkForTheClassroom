using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ChatGroupStudent
    {
        public int id { get; set; }
        public int chatGroupId { get; set; }
        public int studentId { get; set; }
        public bool isAdmin { get; set; } = false;
        public ChatGroup chatGroup { get; set; }

    }
}
