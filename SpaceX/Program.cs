using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX
{
    class Program
    { 


        static void Main(string[] args)
        {
            //creating a variable WT = meaning wallet total.
            int WT = 3000;
            string value = "BTC";

            //User taking the following trips
            int trip1 = 500;
            int trip2 = 50;
            int trip3 = 200;

            //create a variable TT meaning total trips 
            int TT ;
            TT = trip1 + trip2 + trip3;

            //create a variable BAT meaning Balance after trips
            int BAT; 
            BAT = WT - TT;
           Console.WriteLine("Balance after total trips" + " " + BAT + value);
           Console.ReadLine();

        }
    }
}
