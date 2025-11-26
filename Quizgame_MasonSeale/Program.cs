using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizgame_MasonSeale
{
    
    internal class Program
    {
        static List<int> correct = new List<int>();
        static List<string> questions = new List<string>();
        static List<string> options = new List<string>();
        
        static int current = 0;
        static string playername;
        static int playerchoice;
        static int points = 0;
        static bool ending = false;


        static void Main(string[] args)
        {
            optionsetup();
            questionsetup();
            listsetup();
            Console.WriteLine("Please enter a name:");
            playername = Console.ReadLine();
            while (true)
            {

                for (int i = 0; i < correct.Count; i++)
                {
                    hud();
                    Console.WriteLine(questions[current]);
                    Console.WriteLine(options[current]);
                    playerguess();
                    checker();
                    current += 1;
                    Console.ReadKey(true);
                }
                endcheck();
                if(ending == true)
                {
                    break;
                }

            }
            Console.WriteLine("end");
        }
        static void playerguess()
        {
            while (ending == false)
            {


                ConsoleKeyInfo holder = Console.ReadKey(true);
                if (holder.Key == ConsoleKey.D1)
                {
                    playerchoice = 1;
                    break;
                }
                if (holder.Key == ConsoleKey.D2)
                {
                    playerchoice = 2;
                    break;
                }
                if (holder.Key == ConsoleKey.D3)
                {
                    playerchoice = 3;
                    break;
                }
                if (holder.Key == ConsoleKey.D4)
                {
                    playerchoice = 4;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid, try again");
                }
            }
        }
        static void checker()
        {
            if(playerchoice == correct[current])
            {
                Console.WriteLine("correct");
                points += 1;
            }
            else if(playerchoice != correct[current])
            {
                Console.WriteLine("incorrect");
            }
        }
        static void hud()
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write($"{playername}, {points *100 /correct.Count}%, Question#{current + 1}");
            Console.WriteLine();
        }
        static void listsetup()
        {
            correct.Add(1);
            correct.Add(2);
            correct.Add(3);
            correct.Add(3);
            correct.Add(2);
        }
        static void questionsetup()
        {
            questions.Add("Question 1: What is a statement that is like an if, but takes cases?");
            questions.Add("Question 2: This will cause an error, why?  if(int a = x){...");
            questions.Add("Question 3: What Kind of loop is most likely to freeze a computer?");
            questions.Add("Question 4: what is it called when a number in the int value goes from its highest value to the lowest?");
            questions.Add(@"Question 5: if I use this to read a file... string[]map = File.ReadAllLines(path)... what dose the string ""path"" equal if the file is called data.text?");
        }
        static void optionsetup()
        {
            options.Add("1. switch 2. else 3. or . 4. if");
            options.Add("1. x and a are different variables, 2. needs == not =, 3. x dose not equal a  4. something outside the statement");
            options.Add("1. for, 2. foreach, 3. while, 4. none of the above");
            options.Add("1. underflow 2. overlap 3. overflow 4. a problem");
            options.Add(@"1. data.text, 2.""data.txt"", 3. find(data.text) 4. Data");
        }
        static void endcheck()
        {

            Console.Clear();
            Console.WriteLine($"Final Score {points * 100 / correct.Count}");
            Console.WriteLine("Would you like to go again?");
            
            while (true)
            {
                ConsoleKeyInfo holder = Console.ReadKey(true);


                if (holder.Key == ConsoleKey.Y)
                {
                    points = 0;
                    current = 0;
                    Console.Clear();
                    Console.WriteLine("Very well");
                    Console.ReadKey(true);
                    break;
                }
                if (holder.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("Understood");
                    Console.WriteLine("Have a nice day");
                    Console.ReadKey();
                    ending = true;
                    break;
                }
                Console.WriteLine("Y or N");
            }
        }
    }
}

