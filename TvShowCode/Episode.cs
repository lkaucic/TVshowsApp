using System;
using System.Collections.Generic;
using System.Text;

namespace TvShowCode
{
    public class Episode
    {
 
        public string Name { get; set; }
        public int Number { get; set; }
        public int Runtime { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public Image Image { get; set; }

        public override string ToString()
        {
            return $"Episode {Number}: {Name}";
        }

    }
}
