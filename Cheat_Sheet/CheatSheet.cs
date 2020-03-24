using System;

namespace Cheat_Sheet
{
    class CheatSheet
    {
        static void Main(string[] args)
        {
            // DataType
            int num = 50;
            string fullName = "EdgarWu";
            bool isMale = true;

            // Convert a String to Integer
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 7);

            // Store a number & Convert String to Double
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Array

                // Create an Array
                int[] luckyNumbers = {3, 5, 7, 10, 8, 4, 107};

                    // Get number 7
                    Console.WriteLine(luckyNumbers[2]);
                    Console.ReadLine();

                    // Replace 5 to 17
                    luckyNumbers[1] = 17;

                // Create an empty Array
                string[] friends = new string[2]; // Hold 2 value in this Array
                friends[0] = "Claudia";
                friends[1] = "Tom";

            // If Statement
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are tall male");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are male but short.");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not male but tall.");
            } else {
                Console.WriteLine("You are not male and short.");
            }

            // GetMax Method
            Console.WriteLine(GetMax(7,84,107));
            Console.ReadLine();

            // Call SayHi Method
            SayHi("Edgar", 36);
            SayHi("Claudia", 38);

            // Call cube Method          
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            // GetDay Method
            Console.WriteLine(GetDay(0));
        }

        // Methods
        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + "You are " + age);
        }

        // Return Statement
        static int cube(int num2) 
        {
            int result = num2 * num2 * num2;
            return result;
        }

        static int GetMax(int numA, int numB, int numC) 
        {
            int resultMax;
            if (numA >= numB && numA >= numC) {
                resultMax = numA;
            }else if (numB >= numA && numB >= numC)
            {
                resultMax = numB;
            }else
            {
                resultMax = numC;
            }
            return resultMax;
        }

        // Switch Statement
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum) {
                case 0: 
                    dayName = "Sunday";
                    break; 
                case 1: 
                    dayName = "Monday";
                    break; 
                case 2: 
                    dayName = "Tuesday";
                    break; 
                case 3: 
                    dayName = "Wednesday";
                    break; 
                case 4: 
                    dayName = "Thursday";
                    break; 
                case 5: 
                    dayName = "Friday";
                    break; 
                case 6: 
                    dayName = "Saturdy";
                    break; 
                default: 
                    dayName = "Invalid Day Number";
                    break;
            }            
            return dayName;
        }
    }
}
