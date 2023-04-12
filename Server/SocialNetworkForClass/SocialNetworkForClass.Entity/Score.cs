using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Score
    {
        public int id { get; set; }
        public int classId { get; set; }
        public int studentId { get; set; }
        public string name { get; set; } = string.Empty;
        public double midtermScore { get; set; }
        public double finalScore { get; set; }
        public double averageScore { get; set; }
        public Student student { get; set; }
        public Class @class { get; set; }
    }
}
