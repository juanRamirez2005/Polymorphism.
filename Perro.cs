﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Perro: Animal
    { 
        public override void HacerRuido()
        {
            Console.WriteLine("El perro hace: Guaau");
        }
    }
}
