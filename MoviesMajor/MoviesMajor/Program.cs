using System;
using System.Threading;

namespace MoviesMajor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //General Information
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            string nameOfGame = "MoviesMajor";
            string gameRules = "The rules of the game are very simple. \nThe player begins to answer on seven common questions. \nBy earning two points in a row, you can get bonus points. \nAnswer by choosing the appropriate number on the keyboard. \nAt the end, the player's level is displayed. It's up to you to be a loser or the smarty-pants!\n";
            
            Console.WriteLine(gameRules);
            Console.ResetColor();
            
            int resultScore = 0;

            //GetBonus method
            void GetBonusPoint(ref int score)
            {
                score += 2;
                PrintBonusBackColor();
                Console.WriteLine($"BONUS! Wasn't expecting? Our word is law. You already have {score} points");
                Console.ResetColor();
            }

            Console.WriteLine("Enter your name bro...");
            string nameOfPlayer = Console.ReadLine();
            
            //Default value if user didn't specify a name
            if (nameOfPlayer.Length == 0)
            {
                nameOfPlayer = "Player";  
            }

            
            Console.WriteLine("{0}, welcome to {1}", nameOfPlayer, nameOfGame);
            Console.WriteLine("The first question is coming...\n");

            
            Console.Write("In The Matrix, does Neo take the\n" +
                          "1) - blue pill\n" +
                          "2) - red pill? ");
            
            string firstQuestionAnswer = Console.ReadLine();
            int modifiedFirstQuestionAnswer = string.IsNullOrWhiteSpace(firstQuestionAnswer) ? 0 : int.Parse(firstQuestionAnswer);

            Console.WriteLine("Eeeeem");
            Thread.Sleep(650);
            switch (modifiedFirstQuestionAnswer)
            {
                case 1:
                    Console.WriteLine("Isn't true.\n" +
                                      "Pull yourself together and try to calm down. Your score is {0}\n", resultScore);
                    break;
                case 2:
                    PrintCorrectBackColor();
                    Console.WriteLine("Correctly. Your score is {0}\n", ++resultScore);
                    Console.ResetColor();
                    break;
                default:
                    PrintErrorBackColor();
                    Console.WriteLine("Only number 1 or 2. You didn't choose an answer\n");
                    Console.ResetColor();
                    break;
            }
            Console.WriteLine();
            

            
            try
            {
                Console.Write("Who built C-3PO??\n" +
                    "1) - Anakin Skywalker.\n" +
                    "2) - Luke Skywalker.\n" +
                    "3) - Poe Dameron ");
                
                int secondQuestionAnswer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I don't remember let me check it out");
                Thread.Sleep(750);
                
                if (secondQuestionAnswer == 1)
                {
                    PrintCorrectBackColor();    
                    Console.WriteLine("Keep it up. Your score is {0}\n", ++resultScore);
                    Console.ResetColor();
                }
                else if (secondQuestionAnswer == 2)
                {
                    Console.WriteLine("Isn't true. Your score is {0}\n", resultScore);
                }
                else
                {
                    PrintErrorBackColor();
                    Console.WriteLine("Go and watch the first part of Star Wars series\n");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                PrintErrorBackColor();
                Console.WriteLine("You didn't answer the question");
                Console.ResetColor();
            }

            if (resultScore == 2)
            {
                GetBonusPoint(ref resultScore);
            }

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.Write("Next one. What was the name of the main female character in Titanic?\n" +
                "1) - Sarah.\n" +
                "2) - Rose.\n" +
                "3) - Catherine ");

            string thirdQuestionAnswer = Console.ReadLine();
            
            if (string.IsNullOrEmpty(thirdQuestionAnswer))
            {
                
                Console.WriteLine("I also don't know.");
                
            }

            switch (thirdQuestionAnswer)
            {
                case "1":
                    Console.WriteLine("Isn't true. Your score is {0}\n", resultScore);
                    break;
                case "2":
                    PrintCorrectBackColor();
                    Console.WriteLine("Correctly. Your score is {0}\n", ++resultScore);
                    Console.ResetColor();
                    break;
                default:
                    PrintErrorBackColor();
                    Console.WriteLine("Only number 1, 2 or 3 in this answer.You didn't choose any of this\n");
                    Console.ResetColor();
                    break;
            }

            


            Console.Write("Who is Draco Malfoy's dad in Harry Potter?\n" +
                    "1) - Rubeus Hagrid\n" +
                    "2) - Lucius Malfoy\n" +
                    "3) - Salazar Slytherin ");
            string fourthQuestionAnswer = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fourthQuestionAnswer))
            {
                PrintErrorBackColor();
                Console.WriteLine("You didn't choose any of this\n");
                Console.ResetColor();
            }
            switch (fourthQuestionAnswer)
            {
                case "1":
                    Console.WriteLine("Isn't true. Your score is {0}\n", resultScore);
                    break;
                case "2":
                    PrintCorrectBackColor();    
                    Console.WriteLine("Correctly. Your score is {0}\n", ++resultScore);
                    Console.ResetColor();
                    break;
                case "3":
                    PrintErrorBackColor();
                    Console.WriteLine("Isn't true. Your score is {0}\n", resultScore);
                    Console.ResetColor();
                    break;
               

            }

            if (resultScore == 6)
            {
                GetBonusPoint(ref resultScore);
            }

            
            Console.Write("What is the name of the newspaper editor played by JK Simmons?\n" +
                "1) - J. Jonah Jameson\n" +
                "2) - Jim Gordon\n" +
                "3) - Burt Bradley ");
            string fifthQuestionAnswer = Console.ReadLine();
            Thread.Sleep(650);
            
            if (string.IsNullOrEmpty(thirdQuestionAnswer))
            {

                Console.WriteLine("I also don't know.");

            }
             switch (fifthQuestionAnswer)
            {
                case "1":
                    PrintCorrectBackColor();
                    Console.WriteLine("Correctly. Your score is {0}\n", ++resultScore);
                    Console.ResetColor();
                    break;
                case "2":
                    Console.WriteLine("Isn't true. Your score is {0}\n", resultScore);
                    break;
                case "3":
                    Console.WriteLine("Nope!. Your score is {0}\n", resultScore);
                    break;
                default:
                    PrintErrorBackColor();
                    Console.WriteLine("Only number 1, 2 or 3 in this answer.You didn't choose any of this\n");
                    Console.ResetColor();
                    break;
            }


            Console.Write("Who played the lead role in the first Installment of Indiana Jones?\n" +
                "1) - Walter Fielding\n" +
                "2) - Harrison Ford\n" +
                "3) - Steven Hiller ");
            string sixthQuestionAnswer = Console.ReadLine();

            if (string.IsNullOrEmpty(thirdQuestionAnswer))
            {

                Console.WriteLine("I also don't know.");

            }

            switch (sixthQuestionAnswer)
            {
                case "1":
                    Console.WriteLine("Isn't true. Your score is {0}\n", resultScore);
                    break;
                case "2":
                    PrintCorrectBackColor();
                    Console.WriteLine("Correctly. Your score is {0}\n", ++resultScore);
                    Console.ResetColor();
                    break;
                case "3":
                    Console.WriteLine("Nope!. Your score is {0}\n", resultScore);
                    break;
                default:
                    PrintErrorBackColor();
                    Console.WriteLine("Only number 1, 2 or 3 in this answer.You didn't choose any of this\n");
                    Console.ResetColor();
                    break;
            }

            if (resultScore == 10)
            {
                GetBonusPoint(ref resultScore);
            }


            Console.WriteLine("Сongratulations mini-game completed. How successful we will find out after calculating the result");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(850);

            }

            if (resultScore < 2)
            {
                Console.WriteLine($"HORRIBLY!!! Your result is {resultScore} points");
            } else if (resultScore >= 2 && resultScore <= 5)
            {
                Console.WriteLine($"You must know something, don't you? Your result is {resultScore} points");
            } else if (resultScore >= 6 && resultScore <= 8)
            {
                Console.WriteLine($"No kidding, you are a movie master. Your result is {resultScore} points");
            } else if(resultScore > 8)
            {
                Console.WriteLine($"Джеймс Кемерон випадково не твiй знайомий? Звання справжнього розумника твоє. Дякую за гру!!!");
            }

            Console.Read();
            Console.Read();
            Console.Read();


        }

        public static void PrintCorrectBackColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void PrintErrorBackColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintBonusBackColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
        }



    }

    
}
