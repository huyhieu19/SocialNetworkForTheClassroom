using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Class : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherClassId { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
