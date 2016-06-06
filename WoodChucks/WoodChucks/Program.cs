using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodChucks
{
    class Program
    {
     
        static void Main(string[] args)
        {


            int days = 0; //Days gone by
            double woodRate = 2;
            double woodTotal = 0;
            double rateIncrease = .5;


            while (woodTotal <= 1000)//Loop every 2 days after woodchuck rate increase
            {
                woodTotal = woodTotal + woodRate;
                days++;
                Console.WriteLine(woodTotal);
                if (woodTotal >= 1000) //Break from loop if goal reach before rateIncrease
                {
                    break;
                }
                woodTotal = woodTotal + woodRate;
                days++;
                woodRate = woodRate + woodRate * rateIncrease; //Wood chuck rate Increase
                Console.WriteLine(woodTotal);
            }

            Console.WriteLine(days + " Days");
            Console.ReadLine();
        }

   
    }
}
