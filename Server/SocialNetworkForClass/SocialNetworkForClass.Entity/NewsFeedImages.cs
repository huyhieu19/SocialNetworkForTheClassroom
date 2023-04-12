using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsFeedImages
    {
        public int id { get; set; }
        public int newsFeedId { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public NewsFeed newsFeed { get; set; }
        
    }
}
