using System;


namespace TemperatureSerre
{
    class Program
    {
        static void Main(string[] args)
      
        {
            Console.WriteLine("inserisci la temperatura della serra");
            double t = double.Parse(Console.ReadLine());
            if (t == 18)
            {
                Console.WriteLine("la temperatura della serra è normale");
            }
            if (t < 5)
            {
                Console.WriteLine("la temperatura della serra provoca danni irreparabili");
            }
            if (t < 18 && t > 5)
            {
                Console.WriteLine("la serra è in una situazione pericolosa");
            }
            Console.ReadLine();
            
        }
    }
}
