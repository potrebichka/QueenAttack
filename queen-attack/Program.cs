
using System;
using QueenAttacks.Models;

namespace QueenAttacks {
    public class Program{
        public static void Main(){
            Console.WriteLine("Welcome to Queen Attack Program!");
            Console.WriteLine("Enter x coordinate for Queen: ");
            int xq = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate for Queen: ");
            int yq = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x coordinate for chess piece: ");
            int xc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate for chess piece: ");
            int yc = int.Parse(Console.ReadLine());

            Queen queen = new Queen(xq,yq);
            if(queen.checkCoordinates()){
                Console.WriteLine("Queen can attack this piece of chess.");
            }
            else{
                Console.WriteLine("Queen cannot attack this piece of chess.");
            }
            Console.WriteLine("End of the Program. Do you want to repeat? [yes/no]");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "yes") {
                Main();
            } else if (userAnswer == "no") {
                Console.WriteLine("See you next time!");
            } else {
                Console.WriteLine("Not correct answer!");
                Console.WriteLine("See you next time!");
            }
        }
    }
}
