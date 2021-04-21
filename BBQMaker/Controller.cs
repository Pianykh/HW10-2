using BBQMaker.Meat;
using static System.Console;

namespace BBQMaker
{
    class Controller
    {
        public static void ShowMenu()
        {
            var barbecue = new BBQMaker();

            while (true)
            {
                WriteLine("Choose action:\n1. Load Meat in Grill\n2. Press \"Pork\"\n" +
                          $"3. Press \"Chicken\"\n4. Press \"Beef\" {(barbecue.LoadedMeat != null ? "\n5. Get the meat out" : "")}");

                switch (ReadLine())
                {
                    case "1":
                        if (barbecue.LoadedMeat == null)
                        {
                            barbecue.LoadedMeat = ChooseMeatMenu();
                            WriteLine("Meat loaded");
                        }
                        else
                            WriteLine("Meat already in");
                        break;
                    case "2":
                        barbecue.CookPork();
                        break;
                    case "3":
                        barbecue.CookChicken();
                        break;
                    case "4":
                        barbecue.CookBeef();
                        break;
                    case "5" when (barbecue.LoadedMeat != null):
                        barbecue.LoadedMeat = null;
                        WriteLine("The meat is pulled out");
                        break;
                    default:
                        WriteLine("Incorrect operation");
                        break;
                }
            }
        }

        private static AbstractMeat ChooseMeatMenu()
        {
            AbstractMeat chosenMeat = null;

            while (chosenMeat == null)
            {
                WriteLine("Choose meat type:\n1. Pork\n2. Chicken\n3. Beef\n");
                switch (ReadLine())
                {
                    case "1":
                        chosenMeat = new Pork();
                        break;
                    case "2":
                        chosenMeat = new Chicken();
                        break;
                    case "3":
                        chosenMeat = new Beef();
                        break;
                    case "4":
                        chosenMeat = new Veal();
                        break;
                    default:
                        WriteLine("Use 1, 2, 3, 4 to choose meat. Try again.");
                        break;
                }
            }
            return chosenMeat;
        }
    }
}
