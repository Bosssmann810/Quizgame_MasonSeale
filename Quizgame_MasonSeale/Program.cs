using Microsoft.Win32;
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

        static int invalidcounter = 0;
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(questions[current]);
                    Console.ForegroundColor = ConsoleColor.White;
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
                    invalidcounter += 1;
                    if(invalidcounter == 2)
                    {
                        Console.WriteLine("use the number keys");
                    }
                    if(invalidcounter == 10)
                    {
                        Console.WriteLine("Are you dumb on purpose?");
                    }
                    if(invalidcounter == 20)
                    {
                        Console.WriteLine("The joke is getting old");
                    }
                    if(invalidcounter == 30)
                    {
                        Console.WriteLine("Enough");
                    }
                    if(invalidcounter == 40)
                    {
                        Console.WriteLine("Fine I just wont say anything new");
                    }
                    if(invalidcounter == 100)
                    {
                        Console.WriteLine("FOR THE LOVE OF GOD JUST USE THE NUMBER KEYS");
                    }
                    if(invalidcounter == 110)
                    {
                        Console.WriteLine("Why?");
                    }
                    if(invalidcounter == 111)
                    {
                        Console.WriteLine("Is this some kind of sick joke?");
                    }
                    if (invalidcounter== 112)
                    {
                        Console.WriteLine("Do you think this is funny?");
                    }
                    if (invalidcounter == 113)
                    {
                        Console.WriteLine("stop");
                    }
                    if (invalidcounter == 114)
                    {
                        Console.WriteLine("please just stop");
                    }
                    if(invalidcounter == 115)
                    {
                        Console.WriteLine("do you even remember the question?");
                    }
                    if(invalidcounter == 116)
                    {
                        Console.WriteLine("if I tell you the answer will you stop?");
                    }
                    if(invalidcounter == 117)
                    {
                        Console.WriteLine($"it's {correct[current]}");
                    }
                    if(invalidcounter >= 118)
                    {
                        Console.WriteLine("...");
                    }
                    Console.WriteLine("Invalid, try again");
                }
            }
        }
        static void checker()
        {
            if(playerchoice == correct[current])
            {
                invalidcounter = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("correct");
                points += 1;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(playerchoice != correct[current])
            {
                invalidcounter = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrect");
                Console.ForegroundColor = ConsoleColor.White;
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
            correct.Add(1);
            correct.Add(3);
            correct.Add(4);
            correct.Add(3);
            correct.Add(4);

           
        }
        static void questionsetup()
        {
            questions.Add("Question 1: What is a statement that is like an if, but takes cases?");
            questions.Add("Question 2: This will cause an error, why?  if(int a = x){...");
            questions.Add("Question 3: What Kind of loop is most likely to freeze a computer?");
            questions.Add("Question 4: What is it called when a number in the int value goes from its highest value to the lowest?");
            questions.Add(@"Question 5: If I use this to read a file... string[]map = File.ReadAllLines(path)... what dose the string ""path"" equal if the file is called data.txt?");
            questions.Add("Question 6: While using SetCursorPosition(0,0)... what happens when you add one to the second item?");
            questions.Add("Question 7: What happens when a private variable is used in a static method?");
            questions.Add("Question 8: If visual studio ever stops being able to start debugging, even if there is no errors, what must you do?");
            questions.Add("Question 9: What is the file extension name for the file github puts into a repo?");
            questions.Add("Question 10: In the indie game Ultrakill what weapon dose the most damage in a SINGLE shot");
        }
        static void optionsetup()
        {
            options.Add("│ 1. switch │ 2. else │ 3. or │ 4. if │");
            options.Add("│ 1. x and a are different variables │ 2. needs == not = │ 3. x dose not equal a │ 4. something outside the statement │");
            options.Add("│ 1. for │ 2. foreach │ 3. while │ 4. none of the above │");
            options.Add("│ 1. underflow 2. │ overlap │ 3. overflow │ 4. a problem │");
            options.Add(@"│ 1. data.txt │ 2.""data.txt"" │ 3. find(data.text) │ 4. Data │");
            options.Add("│ 1. it will move down │ 2. it will move right │ 3. it will move left │ 4. it will move up │");
            options.Add("│ 1. nothing important │ 2. it gives you a warning but continue │ 3. it will not function │ 4. it will instantly crash your computer │");
            options.Add("│ 1. punch the monitor │ 2. prey │ 3. close visual studio via task manager │ 4. restart the pc │");
            options.Add("│ 1. .get │ 2. .got │ 3. .git │ 4. .txt │");
            options.Add("│ 1. Marksmin Pistol │ 2. projectile boosted shotgun │ 3. Freeze frame charged rocket │ 4. full speed pumpcharge jackhammer │");
        }
        static void endcheck()
        {

            Console.Clear();
            Console.WriteLine($"Final Score {points * 100 / correct.Count}");
            if(points > 9)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"A perfect score, Well done {playername}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(points >=5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"A passing mark, Well done {playername}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(points < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You have failed {playername}");
                Console.ForegroundColor = ConsoleColor.White;
            }
                Console.WriteLine("Would you like to go again?");
            
            while (true)
            {
                Console.WriteLine("Y or N");
                ConsoleKeyInfo holder = Console.ReadKey(true);
                

                if (holder.Key == ConsoleKey.Y)
                {
                    points = 0;
                    current = 0;
                    Console.Clear();
                    Console.WriteLine("Very well");
                    Console.WriteLine("Then we shall go again");
                    Console.ReadKey(true);
                    break;
                }
                if (holder.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("Understood");
                    Console.WriteLine($"Have a nice day {playername}");
                    Console.ReadKey(true);
                    ending = true;
                    break;
                }
            }
        }
    }
}

