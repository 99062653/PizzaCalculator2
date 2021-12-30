namespace RicksPizza
{
    class Program
    {
        public static double smallPizzaPrice, mediumPizzaPrice, largePizzaPrice;
        public static int cartAmount;
        public static double cartPrice;
        public static string pizzaChoiceMade = "";
        public static double pizzaChoicePrice;
        static void Settings()
        {
            smallPizzaPrice = 6.25;
            mediumPizzaPrice = 12.25;
            largePizzaPrice = 19.95;

            cartAmount = 0;
            cartPrice = 0.0;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void pizzaChoices()
        {
            Console.WriteLine("---------RICK'S PIZZA---------");
            Console.WriteLine("WELKE MAAT WILT U BESTELLEN");
            Console.WriteLine($"(S)MALL: \u20AC{smallPizzaPrice}");
            Console.WriteLine($"(M)EDIUM: \u20AC{mediumPizzaPrice}");
            Console.WriteLine($"(L)ARGE: \u20AC{largePizzaPrice}");
            Console.WriteLine("------------------------------");
            pizzaChoiceMade = Console.ReadKey().Key.ToString();

            getamountPizza();
        }
        public static void getamountPizza()
        {
            switch (pizzaChoiceMade)
            {
                default:
                    Console.WriteLine("DEZE PIZZA HEBBEN WE NIET (ERROR 404)");
                    pizzaChoices();
                    break;
                
                case "S": case "SMALL":
                    pizzaChoiceMade = "SMALL";
                    pizzaChoicePrice = smallPizzaPrice;
                    break;
                
                case "M": case "MEDIUM":
                    pizzaChoiceMade = "MEDIUM";
                    pizzaChoicePrice = mediumPizzaPrice;
                    break;
                
                case "L": case "LARGE":
                    pizzaChoiceMade = "LARGE";
                    pizzaChoicePrice = largePizzaPrice;
                    break;
            }
            Console.WriteLine($"HOEVEEL {pizzaChoiceMade} PIZZA'S WILT U? ");
            try
            {
                cartAmount = Convert.ToInt32(Console.ReadLine());
                if (cartAmount >= 1)
                {
                    checkoutPizza();
                }
                else 
                {
                    Console.WriteLine("0 PIZZA'S KAN NIET");
                    getamountPizza();
                }
            }
            catch 
            {
                Console.WriteLine("DAT WAS GEEN CIJFER!");
                getamountPizza();
            }
        }
        static void checkoutPizza()
        {
            Console.WriteLine("---------RICK'S PIZZA---------");
            Console.WriteLine("HIER IS UW BON!");
            
            for (int r = 0; r < cartAmount; r++)
            {
                cartPrice += pizzaChoicePrice;
                Console.WriteLine($"1 {pizzaChoiceMade} PIZZA = \u20AC{pizzaChoicePrice}");
            }
            cartPrice = Math.Round(cartPrice, 2);
            Console.WriteLine($"AANTAL = \u20AC{cartPrice}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("DRUK OP ENTER OM TE BETALEN");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine($"OVER 15 MINUTEN STAAN WE VOOR JE DEUR {Environment.MachineName} ;)");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        static void Main()
        {   
            Settings();
            Console.WriteLine("WELKOM BIJ RICK'S PIZZA \nKLIK ENTER OM VERDER TE GAAN");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                pizzaChoices();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}