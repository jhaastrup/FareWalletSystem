using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX 

/// SpaceX	runs	a	futuristic	space	travel	system	within	our	solar	system	with	payments	
//done	with	bitcoin	currency	(BTC) wallet	system.	They	have	2	rockets:	Falcon	1	and	
//Falcon	9
//You	are	required	to	model	the	following	fare	wallet	system.	At	the	end	of	the	test,	you	
//should	be	able	to	demonstrate	a	user	loading	a	wallet	with	3000BTC,	and	taking	the	
//following	trips,	and	then viewing	the	balance.
//- Taking	the	Falcon	9	from	Abuja	station	to	the	Moon	
//- Taking	the	Falcon	1	from	the	Moon	to	Spock	station	on	Mars
//- Taking	the	Falcon	9	from	Mars	to	the	International	Space	Station	(ISS)	in	Lower	Earth.
//The	Falcon	9	is	a	luxury	spacecraft	with	better	experience.	Its	passengers	pay	twice	the	fare	of	
//the	Falco 

//From the problem statement, taking falcon 9 is twice the price of falcon1 
//so if falcon 1 is 250BTC, falcon9 will be 500BTC.
//which gives us trip1.
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
