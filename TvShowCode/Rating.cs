using System;
using System.Collections.Generic;
using System.Text;

namespace TvShowCode
{
    public class Rating
    {
        public double? Average { get; set; }

        public override string ToString()
        {
            return $"{Average}";
        }
    }
}
