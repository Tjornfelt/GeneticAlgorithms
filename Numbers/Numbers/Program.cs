using Numbers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        /*
        exercise: Write a genetic algorithm that calculates the
        smallest numbers added together to make a certian value.
        Tricky part: each number can only be used ONCE!
        */

        const int goal = 100;
        const int maxRuns = 50;

        static void Main(string[] args)
        {
            for (int i = 0; i < maxRuns; i++)
            {
                NumberWorker Worker = new NumberWorker();
                Worker.Number = i;
            }
        }
    }
}
