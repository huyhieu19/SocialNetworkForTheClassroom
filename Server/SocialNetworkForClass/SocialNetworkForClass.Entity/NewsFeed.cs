using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsFeed : EntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Images { get; set; }
        public string Tags { get; set; }
    }
}
