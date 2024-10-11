namespace Text_Adventure
{
    internal class Program
    {
        public int Tokens = 3;
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tWelcome to the game of doors!");
            Progression(ConsoleKey.Enter);
            Console.WriteLine("\tin this game you will choose from a series of doors");
            Thread.Sleep(2000);
            Console.WriteLine("\tyou will choose from these doors to enter.");
            Thread.Sleep(2000);
            Console.WriteLine("\tBut you should be very carefull as these doors will also contain your fate");
            Thread.Sleep(2000);
            Console.WriteLine("\tNow you must be carefull as anything can be behind these doors and some may cost you your life");
            Thread.Sleep(2000);
            Console.WriteLine("\tthrought the game you will have 3 tokens that will tell you where these doors lead and whats behind them");
            Thread.Sleep(2000);
            Console.WriteLine("\tyou have to Be carefull as you will only have 3 of these tokens so don't use them too early,");
            Console.WriteLine("\tbut if you save them for to late it may lead to your death");
            Thread.Sleep(2000);
            Console.WriteLine("\tAre you ready to Progress???");
            Console.WriteLine("\t\t|Yes|No|");
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
        }
            public static void LifeOrDeath()
            {
            Random random = new Random();
            int DoorOneLifeOrDeath = random.Next(0, 5);
            int DoorTwoLifeOrDeath = random.Next(0, 5);
            int DoorThreeLifeOrDeath = random.Next(0, 5);
        }
            static void Death()
            {
                Console.WriteLine("\tsorry but unfortunitly you have made the wrong decision");
                Thread.Sleep(4000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tYOU HAVE DIED");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\twould you like to try again?");
                Console.WriteLine("\t\t|Yes|No|");
                string TryAgain = Console.ReadLine();
                if (TryAgain == "Yes" || TryAgain == "yes" || TryAgain == "YES")
                {
                    Console.WriteLine("\tThen Let's try this again shall we");
                    Thread.Sleep(3000);
                    Start();
                }
                if (TryAgain == "No" || TryAgain == "no" || TryAgain == "NO")
                {

                }
            }
        static void Doors()
        {
            Console.Write("\tthe door on the left is a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.DoorOneColor);
            Console.Write(Door.DoorOneColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Door with a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.TrimOneColor);
            Console.Write(Door.TrimOneColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trim");
            Console.Write("\tthe door in the middle is a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.DoorTwoColor);
            Console.Write(Door.DoorTwoColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Door with a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.TrimTwoColor);
            Console.Write(Door.TrimTwoColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trim");
            Console.Write("\tthe door on the left is a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.DoorThreeColor);
            Console.Write(Door.DoorThreeColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Door with a ");
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(Door.TrimThreeColor);
            Console.Write(Door.TrimThreeColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trim");
            Console.WriteLine("\t\t\tPlease select Doors");
            Console.WriteLine("\t\t\t|Left|Middle|Right|");
        }
        static void Start()
        {
            Door.RandomDoor();
            Thread.Sleep(3000);
            Console.WriteLine("\tyou see three doors in front of you");
            Doors();
        }
    }
}






        
    



