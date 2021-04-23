using System;
using System.Collections.Generic;

namespace Generics_intro {

    class Program {
    
        static void Main(string[] args) {

            var rnd = new Random();

            var game = new List<int>();
            for(var idx = 1; idx <= 10; idx++) {
                var score = rnd.Next(0, 31);
                game.Add(score);
            }
            var total = 0;
            foreach(var score in game) {
                total += score;
            }
            Console.WriteLine($"Bowling score is {total}");

            //var names = new List<string>();
            //names.Add("Elena");
            //names.Add("Christian");
            //names.Add("Tracy");
            //names.Add("Fred");
            //names.Add("Yvonne");
            //names.Add("Mark");
            //names.Add("Manami");
            //names.Add("Sarah");
            //names.Sort();
            //foreach(var name in names) {
            //    Console.WriteLine(name);
            //}
            //names.Remove("Fred");
            //foreach(var name in names) {
            //    Console.WriteLine(name);
            //}
        }
    }
}
