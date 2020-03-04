using System;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Guess a Number without limit.
            // int bingoNum = 7;
            // int guessNum;
            // Console.Write("Guess a number: ");
            // guessNum = int.Parse(Console.ReadLine());

            // while (guessNum != bingoNum)
            // {
            //     if (guessNum > bingoNum) {
            //     Console.WriteLine("Its grearter than that.");
            //     guessNum = int.Parse(Console.ReadLine());
            //     } else if (guessNum < bingoNum) {
            //     Console.WriteLine("Its less than that.");
            //     guessNum = int.Parse(Console.ReadLine());
            //     } else {
            //         guessNum = bingoNum;                    
            //     }
            // }
            // Console.WriteLine("Bingo!!!");

            // Guess a Number with limit.
            int bingoNum = 7;
            int guessNum = 0;
            int guessCount = 0;
            int guesslimit = 3;
            int guessRemain = guesslimit;
            bool outOfGuesses = false; 

            Console.WriteLine("Hey there! Let's play a little guessing game." + "\n" + "Guess the number between 0 and 10.");
             
            while (guessNum != bingoNum && !outOfGuesses) 
            {                
                if (guessCount < guesslimit)
                {   
                    Console.Write("Guess a number: ");                                        
                    guessNum = int.Parse(Console.ReadLine());
                    guessCount++; 
                    guessRemain--;

                    // Hint
                    if (guessNum > bingoNum)
                    {
                        Console.Write("Its greater than that" + "\n");
                    } else if (guessNum < bingoNum)
                    {
                        Console.Write("Its less than that" + "\n");
                    }

                    // Comment of guesses remaining.
                    if (guessRemain < guesslimit && bingoNum != guessNum)
                    {
                        Console.Write("You have " + guessRemain + " guesses left!" + "\n" + "\n");
                    }    
                }                                                
                else
                {
                    outOfGuesses = true;
                }                
            }
            if (outOfGuesses)
            {
                Console.Write("You run out of your guesses," + "\n");
                Console.Write("Sorry, You Lose!");
            } 
            else
            {
                Console.Write("Bingo! You Win!!!");
            }
        }
    }
}
