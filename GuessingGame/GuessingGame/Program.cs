using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please guess a number between 1-10"); //Prompt user for a number
			string number = Console.ReadLine(); //Assign the user's response to the string 'number'
			string result = (number == "8") ? "You win" : "You lose"; //if the string = 8, then assign "you win" to result. If not, assign "you lose" to result

			Console.WriteLine(result); //display result
			Console.ReadLine();
        }
    }
}
