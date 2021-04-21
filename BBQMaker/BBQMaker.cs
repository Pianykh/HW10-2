using BBQMaker.Meat;
using System.Threading;
using static System.Console;

namespace BBQMaker
{
    class BBQMaker
    {
        public AbstractMeat LoadedMeat { get; set; }

        public void CookPork()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("The Grill is set at 50 degrees for an hour");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: Add the meat first");
        }

        public void CookChicken()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("The Grill is set at 40 degrees for 20 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        public void CookBeef()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("The Grill is set at 60 degrees for 30 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        public void CookVeal()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("Grill set 50 temperature and 10 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        private void Beeep()
        {
            WriteLine("\nBeeeep!!!");
            Beep(300, 1500);
        }

        private void TurnOn()
        {
            WriteLine("Grill turns on");
        }

        private void TurnOff()
        {
            WriteLine("Grill turns off");
        }

        private bool IsMeatLoaded()
        {
            return LoadedMeat != null;
        }
    }
}
