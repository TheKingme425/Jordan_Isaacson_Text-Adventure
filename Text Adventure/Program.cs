namespace Text_Adventure
{
    internal class Program
    {
        public int Tokens = 3;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tWelcome to the game of doors!");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tin this game you will choose from a series of doors");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tyou will choose from these doors to enter.");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tBut you should be very carefull as these doors will also contain your fate");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tNow you must be carefull as anything can be behind these doors and some may cost you your life");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tthrought the game you will have 3 tokens that will tell you where these doors lead and whats behind them");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tyou have to Be carefull as you will only have 3 of these tokens so don't use them too early,");
            Console.WriteLine("\tbut if you save them for to late it may lead to your death");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tAre you ready to Progress???");
            Console.WriteLine("\t\t|Yes|No:");
            ReadyCheck();
        }
        static void Start()
        {
            Thread.Sleep(3000);
            Console.WriteLine("\tyou see three doors in front of you");
            Console.Write("\tthe door on the left is a ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Blue Door ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("with a White Trim");
            Console.Write("\tthe door in the middle is a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Yellow Door ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("with a Brown Trim");
            Console.Write("\tthe door on the left is a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red Door ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("with a green Trim");
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

        static void ReadyCheck()
        {
            string Ready = Console.ReadLine();
            if (Ready == "Yes" || Ready == "yes" || Ready == "YES")
            {
                Console.WriteLine("\t\t\tNOW LET THE GAMES BEGIN!!!");
                Start();
            }
            else if (Ready == "No" || Ready == "no" || Ready == "NO")
            {
                Console.WriteLine("\tit seems you have said no, Unfortunitly for you thats incorrect and you have angered the doors");
                Thread.Sleep(4000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tYOU HAVE DIED");
            }
            else
            {
                Console.WriteLine("\t\tINVALID INPUT TRY AGAIN");
                ReadyCheck();
            }
            static void Death()
            {
                Console.WriteLine("\tsorry but unfortunitly you have made a wrong decision");
                Thread.Sleep(4000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tYOU HAVE DIED");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\twould you like to try again?");
                string TryAgain = Console.ReadLine();
                if (TryAgain == "Yes" || TryAgain == "yes" || TryAgain == "YES")
                {

                }
                if (TryAgain == "No" || TryAgain == "no" || TryAgain == "NO")
                {

                }

            }




        }
    }
}

