using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


//The if single-selection statement selects or ignores a single action, while the while repitition statement performs the same statement repeatedly while it is true.//

namespace DeclareI_Int_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit, speed;
            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("Slow Now");
                Console.ReadLine();
            }







        }
    }
}