﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTuT
{
    class Warrior
    {
        // Name Health Attack Maximum Block Maximum

        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        //Random numbers
        Random rnd = new Random();


        public Warrior(string name = "Warrior", double health = 0, double attkMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }
        //Attack
        //Generate a random attack from 1 to max attack 
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        //Block
        //Generate a random attack from 1 to max attack 
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
