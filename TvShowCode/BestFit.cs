using System;
using System.Collections.Generic;
using System.Text;

namespace TvShowCode
{
    public class BestFit 
    { 
        public Show Show { get; set; }

        public override string ToString()
        {
            return $"{Show.Name}";
        }
    }
}
