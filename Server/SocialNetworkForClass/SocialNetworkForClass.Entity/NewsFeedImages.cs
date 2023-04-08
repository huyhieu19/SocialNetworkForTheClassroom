using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsFeedImages
    {
        public int Id { get; set; }
        public int NewsFeedId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        
    }
}
