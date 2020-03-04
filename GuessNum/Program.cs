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
            int guessRemain = guesslimit - guessCount;
            bool outOfGuesses = false; 
            int[] numRange = {0,1,2,3,4,5,6,7,8,9,10};
            

            Console.WriteLine("Hey there! Let's play a little guessing game." + "\n" + "Guess the number between 0 to " +  numRange[numRange.Length -1] + ".");
             
            while (guessNum != bingoNum && !outOfGuesses) 
            {                
                if (guessCount < guesslimit)
                {   
                    Console.Write("Guess a number: ");                                        
                    guessNum = int.Parse(Console.ReadLine());    
                    if (guessNum > numRange[numRange.Length - 1] || guessNum < numRange[numRange.Length - numRange.Length])
                    {
                        Console.Write("Invalid Number, please try a number between 0 to " + numRange[numRange.Length -1] + "\n");
                    }
                    else 
                    {
                        guessCount++; 
                        guessRemain--;

                        // Hint
                        if (guessNum > bingoNum)
                        {
                            Console.Write("Its less than that" + "\n");
                        } else if (guessNum < bingoNum)
                        {
                            Console.Write("Its greater than that" + "\n");
                        }

                        // Comment for guesses remaining.
                        if (guessRemain < guesslimit && bingoNum != guessNum && guessRemain != 0)
                        {
                            Console.Write("You have " + guessRemain + " guesses left!" + "\n" + "\n");
                        } 
                    }   
                }                                                
                else
                {
                    outOfGuesses = true;
                }                
            }
            if (outOfGuesses)
            {
                Console.Write("Sorry, you run out of your guesses," + "\n" + "You Lose!");
                
            } 
            else
            {
                Console.Write("Bingo! You Win!!!");
            }
        }
    }
}
