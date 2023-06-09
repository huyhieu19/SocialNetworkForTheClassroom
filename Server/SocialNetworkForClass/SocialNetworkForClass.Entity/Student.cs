﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string image { get; set; } = string.Empty;
        public double CPA { get; set; }
        public List<Score> scores { get; set; }
        public List<CommentStudent> commentStudents { get; set; }
    }
}
