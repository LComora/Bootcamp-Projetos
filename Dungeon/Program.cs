using System;
using Dungeon.src.Entities;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jenica = new Wizard("Jenica", 23, "White Wizard");
            Ninja goku = new Ninja("Goku", 32, "Ninja");
            Boss Dragon = new Boss("Zamorak", 189, "Boss");

            Console.WriteLine(goku.Attack(10));
            Console.WriteLine(jenica.Attack(7));
            Console.WriteLine(arus.Attack(12));
            Console.WriteLine(Dragon.Attack(15));


        }
    }
}
