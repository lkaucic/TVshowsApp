using System;
using System.Collections.Generic;
using System.Text;

namespace TvShowCode
{
    public class Show
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public List<string> Genres { get; set; }
        public string Status { get; set; }
        public int Runtime { get; set; }
        public Rating Rating { get; set; }
        public Image Image { get; set; }
        public string Summary { get; set; }




    }

}
