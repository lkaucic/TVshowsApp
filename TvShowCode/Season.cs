using System;
using System.Collections.Generic;
using System.Text;

namespace TvShowCode
{
    public class Season
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int EpisodeOrder { get; set; }

        public override string ToString()
        {
            return $"Season{ Number}";
        }

    }

}
