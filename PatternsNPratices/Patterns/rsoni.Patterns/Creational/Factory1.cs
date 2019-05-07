using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.Patterns.Creational.V2
{
    public sealed class point
    {
        private readonly int x;
        private readonly int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }


        public point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }

    // factory methods as we can not use same signature of constructor. but in static methods.
    public struct BadDuration
    {
        private readonly long ticks;
        public long Ticks { get { return ticks; } }

        public BadDuration(long ticks)
        {
            this.ticks = ticks;
        }


        public static BadDuration FromMilliSeonds(long milliSeconds)
        {
            return new BadDuration(milliSeconds * 10000);
        }

        public static BadDuration FromSeconds(long seconds)
        {
            return new BadDuration(seconds * 1000 * 10000);
        }


    }

    
}
