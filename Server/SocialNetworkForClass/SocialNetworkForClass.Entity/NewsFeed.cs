using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NewsFeed : EntityBase
    {
        public int id { get; set; }
        public string title { get; set; }
        public string images { get; set; }
        public string tags { get; set; }
        public List<ImageNewsFeed> imagesNewFeeds { get; set; }
        public List<NewsFeedStudent> newsFeedStudents { get; set; }
        public List<NewsFeedTeacher> NewsFeedTeachers { get; set; }
    }
}
