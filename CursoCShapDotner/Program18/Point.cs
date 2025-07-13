using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_Dotner.Program18
{
    struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
