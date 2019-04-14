using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTuT
{
    class Battle
    {
        //startFight warrior 1 and warrior 2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {   //loop giving warrior a chance to attack and block each turn until one dies
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        //getAttackResult warriorA warriorB
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            //Calculate one warrior attack and the other blocks
            double warAttackAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            //Subtract block from attack
            double dmg2WarB = warAttackAmt - warBBlkAmt;

            //If there was damage subtract that from health
            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            //Print out info on who attacked whom and for how much damage
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, dmg2WarB);

            //Provide output on the change in health
            Console.WriteLine("{0} Has {1} Health \n", warriorB.Name, warriorB.Health);

            //Check if the warrior health fell below 0 and if so print a message that will end the loop
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} lost and {1} won\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
