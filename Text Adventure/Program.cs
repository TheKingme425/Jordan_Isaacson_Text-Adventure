using System.Dynamic;
using System.Security.Cryptography;

namespace Text_Adventure
{
    internal class Program
    {
        // defined variables
        public static string LifeOrDeathD1 = "LIFE";
        public static string LifeOrDeathD2 = "LIFE";
        public static string LifeOrDeathD3 = "LIFE";
        public static int Tokens = 3;
        public static int DoorsEntered = 0;

        public static void Main(string[] args)
        {
            //int mynumb = Convert.ToInt32(Console.ReadLine());

            // introduction 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tWelcome to the game of doors!");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tin this game you will choose from a series of doors");
            Thread.Sleep(2000);
            Console.WriteLine("\tyou will choose from these doors to enter.");
            Thread.Sleep(2000);
            Console.WriteLine("\tBut you should be very carefull as these doors will also contain your fate");
            Thread.Sleep(2000);
            Console.WriteLine("\tMake it through 10 doors and you will survive");
            Thread.Sleep(2000);
            Console.WriteLine("\tNow you must be carefull as anything can be behind these doors and some may cost you your life");
            Thread.Sleep(2000);
            Console.WriteLine("\tthrought the game you will have 3 tokens that will tell you where these doors lead and whats behind them");
            Thread.Sleep(2000);
            Console.WriteLine("\tyou have to Be carefull as you will only have 3 of these tokens so don't use them too early,");
            Console.WriteLine("\tbut if you save them for to late it may lead to your death");
            Thread.Sleep(2000);
            ReadyCheck();
        }
        static void Progression(ConsoleKey progression_Key)
        {
            Console.WriteLine($"\t\tPress {progression_Key} to progress...");
            bool Spacebar_activated;
            do
            {
                Spacebar_activated = Console.ReadKey().Key == progression_Key;

            } while (!Spacebar_activated);
        }

        //Checks if they are ready for the next room
        static void ReadyCheck()
        {
            Console.WriteLine("\tAre you ready to Progress???");
            Console.WriteLine("\t\t|Yes|No|");
            string Ready = Console.ReadLine()!;
            if (Ready == "Yes" || Ready == "yes" || Ready == "YES")
            {
                Console.WriteLine("\t\t\tWelcome to Room " + DoorsEntered);
                Start();
            }
            else if (Ready == "No" || Ready == "no" || Ready == "NO")
            {
                Death();
            }
            else
            {
                Console.WriteLine("\t\tINVALID INPUT TRY AGAIN");
                ReadyCheck();
            }
        }
        //Decides their fate with random veriables
        public static void LifeOrDeath()
        {
            Random random = new Random();
            int DoorOneLifeOrDeath = random.Next(0, 6);
            int DoorTwoLifeOrDeath = random.Next(0, 6);
            int DoorThreeLifeOrDeath = random.Next(0, 6);
            if (DoorOneLifeOrDeath == 1 && DoorTwoLifeOrDeath == 1 && DoorThreeLifeOrDeath == 1)
            {
                LifeOrDeath();
            }

            else if (DoorOneLifeOrDeath == 1 || DoorTwoLifeOrDeath == 1 || DoorThreeLifeOrDeath == 1)
            {
                if (DoorOneLifeOrDeath == 1)
                {
                    LifeOrDeathD1 = "DEAD";
                }
                if (DoorTwoLifeOrDeath == 1)
                {
                    LifeOrDeathD2 = "DEAD";
                }
                if (DoorThreeLifeOrDeath == 1)
                {
                    LifeOrDeathD3 = "DEAD";
                }
            }
            else if (DoorOneLifeOrDeath > 1 || DoorTwoLifeOrDeath > 1 || DoorThreeLifeOrDeath > 1)
            {
                if (DoorOneLifeOrDeath > 1)
                {
                    LifeOrDeathD1 = "LIFE";
                }
                if (DoorTwoLifeOrDeath > 1)
                {
                    LifeOrDeathD2 = "LIFE";
                }
                if (DoorThreeLifeOrDeath > 1)
                {
                    LifeOrDeathD3 = "LIFE";
                }
            }
        }

        /*
         * int[] array = mew int[5]
         * string[] weekdays = ["sun", "mon", "Tue", "wed", "thu", "fri", "Sat"];
         * 
         * struct Emplyee 
         * {
         * public int id;
         * 
         * public void getID(int id) 
         * {
         * Console.WriteLine("Employee Id: " + id);
         * }
         * }
        */
        static void Restart()
        {
            Console.WriteLine("\twould you like to try again?");
            Console.WriteLine("\t\t|Yes|No|");
            string TryAgain = Console.ReadLine()!;
            if (TryAgain == "Yes" || TryAgain == "yes" || TryAgain == "YES")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("\tThen Let's try this again shall we");
                Thread.Sleep(3000);
                Start();
            }
            else if (TryAgain == "No" || TryAgain == "no" || TryAgain == "NO")
            {

            }
            else
            {
                Console.WriteLine("Invalid answer");
                Thread.Sleep(2000);
                Restart();
            }
        }
            static void Death()
            {
                Console.WriteLine("\tsorry but unfortunitly you have made the wrong decision");
                Thread.Sleep(4000);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("\t\tYOU HAVE DIED");
                Thread.Sleep(3000);
                Restart();
        }
        static void Doors()
        {
            Console.WriteLine("\tyou see three doors in front of you");
            Thread.Sleep(2000);
            Console.Write("\tthe door on the left is a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.DoorOneColor);
            Console.Write(Door.DoorOneColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Door with a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.TrimOneColor);
            Console.Write(Door.TrimOneColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trim");
            Thread.Sleep(1000);
            Console.Write("\tthe door in the middle is a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.DoorTwoColor);
            Console.Write(Door.DoorTwoColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Door with a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.TrimTwoColor);
            Console.Write(Door.TrimTwoColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trim");
            Thread.Sleep(1000);
            Console.Write("\tthe door on the left is a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.DoorThreeColor);
            Console.Write(Door.DoorThreeColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Door with a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.TrimThreeColor);
            Console.Write(Door.TrimThreeColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trim");
            Thread.Sleep(3000);
        }

        static void Win()
        {
            if (DoorsEntered == 10)
            {
                Console.WriteLine("\t\t\tCongrats you win");
            }
            else
            {
                Start();
            }
        }
        static void DoorOpenCheck()
        {
            Console.WriteLine("\t\t\tPlease select Doors");
            Thread.Sleep(1000);
            Console.WriteLine("\t\t|Left|Middle|Right|TOKEN|");
            string Condition = Console.ReadLine()!.ToLower();
            if (Condition == "admin")
            {
                Console.WriteLine("welcome Admin");
                Tokens = 99999;
            }
            if (Condition == "token" && Tokens > 0)
            {
                Tokens = Tokens - 1;
                Thread.Sleep(1000);
                Console.WriteLine("\t\tThe Left Door is " + LifeOrDeathD1);
                Thread.Sleep(1000);
                Console.WriteLine("\t\tThe Middle Door is " + LifeOrDeathD2);
                Thread.Sleep(1000);
                Console.WriteLine("\t\tThe Right Door is " + LifeOrDeathD3);
                Thread.Sleep(1000);
                Console.WriteLine("\t\t\tYou Have " + Tokens + " Tokens Left");
                DoorOpenCheck();
            }
            else if (Tokens == 0)
            {
                Console.WriteLine("You are out of tokens, try again");
                DoorOpenCheck();
            }

            if (Condition == "left")
            {
                if (LifeOrDeathD1 == "LIFE")
                {
                    int LevelsLeft = 10 - DoorsEntered;
                    Console.WriteLine("Congrats for passing Level " + DoorsEntered + " " + LevelsLeft + " Rooms left to go");
                    DoorsEntered = DoorsEntered + 1;
                    Win();
                }
                else
                {
                    Death();
                }
            }
            else if (Condition == "middle")
            {
                if (LifeOrDeathD2 == "LIFE")
                {
                    int LevelsLeft = 10 - DoorsEntered;
                    Console.WriteLine("Congrats for passing Level " + DoorsEntered + " " + LevelsLeft + " Rooms left to go");
                    DoorsEntered = DoorsEntered + 1;
                    Win();
                }
                else
                {
                    Death();
                }
            }
            else if (Condition == "right")
            {
                if (LifeOrDeathD3 == "LIFE")
                { 
                    int LevelsLeft = 10 - DoorsEntered;
                    Console.WriteLine("Congrats for passing Level " + DoorsEntered + " " + LevelsLeft + " Rooms left to go");
                    DoorsEntered = DoorsEntered + 1;
                    Win();
                }
                else
                {
                    Death();
                }
            }
            else
            {
                Console.WriteLine("\t\t\tInvalid Try Again");
                Thread.Sleep(1000);
                DoorOpenCheck();
            }
           

        }

        static void Start()
        {
            LifeOrDeath();
            Door.RandomDoor();
            Doors();
            DoorOpenCheck();
            ReadyCheck();
            Console.Clear();
        }
    }
}