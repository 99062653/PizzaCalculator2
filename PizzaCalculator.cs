namespace RicksPizza
{
    class Program
    {
        public static double smallPizaPrice, mediumPizaPrice, largePizaPrice;
        public static double Cart;
        public static int cartAmount;
        public static string pizzaChoiceMade = "";
        static void Settings()
        {
            smallPizaPrice = 6.25;
            mediumPizaPrice = 12.25;
            largePizaPrice = 19.95;

            Cart = 0;
            cartAmount = 0;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void pizzaChoices()
        {
            Console.WriteLine("---------RICK'S PIZZA---------");
            Console.WriteLine("WELKE MAAT WILT U BESTELLEN");
            Console.WriteLine($"(S)MALL: \u20AC{smallPizaPrice}");
            Console.WriteLine($"(M)EDIUM: \u20AC{mediumPizaPrice}");
            Console.WriteLine($"(L)ARGE: \u20AC{largePizaPrice}");
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
                    break;
                
                case "M": case "MEDIUM":
                    pizzaChoiceMade = "MEDIUM";
                    break;
                
                case "L": case "LARGE":
                    pizzaChoiceMade = "LARGE";
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