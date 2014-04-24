using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParserApplication
{
    public class Sum
    {
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public Sum(int i, int p)
        {
            minValue = i > p ? p : i;
            maxValue = i > p ? i : p;
        }
        public int Add()
        {
            return minValue + maxValue;
        }
        public override string ToString()
        {
            return minValue + " : " + maxValue;
        }
    }
}
