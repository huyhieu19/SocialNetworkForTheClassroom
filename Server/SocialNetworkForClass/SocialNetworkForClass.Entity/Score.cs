using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Score
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double MidtermScore { get; set; }
        public double FinalScore { get; set; }
        public double AverageScore { get; set; }
    }
}
