namespace RicksPizza
{
    class Program
    {
        public static double Cart;
        public static double smallPizaPrice;
        public static double mediumPizaPrice;
        public static double largePizaPrice;
        static void Settings()
        {
            Cart = 0;
            smallPizaPrice = 6.25;
            mediumPizaPrice = 12.25;
            largePizaPrice = 19.95;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void Main()
        {   
            Settings();
            Console.WriteLine("WELKOM BIJ RICK'S PIZZA \nKLIK ENTER OM VERDER TE GAAN");
            var keyPressed = Console.ReadKey().Key;

            if (keyPressed == ConsoleKey.Escape) 
            {
                Environment.Exit(0);
            }

            if (keyPressed == ConsoleKey.Enter)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("WELKE MAAT WILT U BESTELLEN");
                Console.WriteLine($"(S)MALL: \u20AC{smallPizaPrice}");
                Console.WriteLine($"(M)EDIUM: \u20AC{mediumPizaPrice}");
                Console.WriteLine($"(L)ARGE: \u20AC{largePizaPrice}");
                var pizzaChoice = Console.ReadKey().Key;

                switch (pizzaChoice)
                {
                    default:
                        Console.WriteLine("(404) PIZZA MAAT NIET GEVONDEN");
                        break;      

                    case ConsoleKey.S:
                        Cart += smallPizaPrice;
                        break;   

                    case ConsoleKey.M:
                        Cart += mediumPizaPrice;
                        break; 

                    case ConsoleKey.L:
                        Cart += largePizaPrice;
                        break;
                }
                Console.WriteLine("Your total = \u20AC" + Cart);
                Console.ReadKey();
            }
        }
    }
}