using System;
using System.Collections;
using PATRONES_DE_DISEÑO_PARTE1.DoubleDispatch;

namespace program
{
    class Program
    {
        public static void Main(string[] args)
        {  
            Papper papper = new Papper();
            Rock rock = new Rock();

            Console.WriteLine(Convert.ToString(rock.beats(papper))); 
        }
    }
}