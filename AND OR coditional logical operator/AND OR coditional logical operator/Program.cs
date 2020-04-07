using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND_OR_coditional_logical_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            char sex = 'f';

            Console.WriteLine("starting tests... (day:{0}, sex:{1}", day, sex);

            if (day>=1 && day<=7)
            {
                Console.WriteLine("day is from 1 to 7");
            }

            if (sex == 'm' || sex == 'f')
            {
                Console.WriteLine("sex is male of female");
            }

            Console.WriteLine("Done with the checks..");
        }
    }
}
