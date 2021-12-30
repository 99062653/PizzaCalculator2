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

        public static string pizzaChoice()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("WELKE MAAT WILT U BESTELLEN");
            Console.WriteLine($"(S)MALL: \u20AC{smallPizaPrice}");
            Console.WriteLine($"(M)EDIUM: \u20AC{mediumPizaPrice}");
            Console.WriteLine($"(L)ARGE: \u20AC{largePizaPrice}");
            var pizzaChoiceMade = Console.ReadKey().Key.ToString();

            // Console.WriteLine("Choice made: " + pizzaChoiceMade);
            return pizzaChoiceMade;
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
                var pizzaChoiceMade = pizzaChoice();
                string typePizza = "";
                double amountPizza = -48;//anders geeft console.read() een verkeerde waarde terug

                switch (pizzaChoiceMade)
                {
                    default:
                        Console.WriteLine("(404) PIZZA MAAT NIET GEVONDEN");
                        pizzaChoice();
                        break;      

                    case "S":
                        typePizza = "SMALL";
                        Cart += smallPizaPrice;
                        break;   

                    case "M":
                        typePizza = "MEDIUM";
                        Cart += mediumPizaPrice;
                        break; 

                    case "L":
                        typePizza = "LARGE";
                        Cart += largePizaPrice;
                        break;
                }

                Console.Write($"HOEVEEL {typePizza} PIZZA'S WILT U? ");
                amountPizza = Console.Read();

                Console.WriteLine("Your total = \u20AC" + Cart * amountPizza);
                Console.WriteLine("calculations: " + Cart + " * " + amountPizza + " = " + Cart * amountPizza);
                Console.ReadKey();
            }
        }
    }
}