using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your dice roll:");
            string[] usrInput = Console.ReadLine().Split("d");
            if (usrInput.Length != 2)
            {
                Console.WriteLine("Please use valid formatting");
                return;
            }
            
            int rolled, faces;
            try
            {
                rolled = Convert.ToInt32(usrInput[0]);
                faces = Convert.ToInt32(usrInput[1]);
            }
            catch
            {
                Console.WriteLine("Please use valid formatting");
                return;
            }
            Console.WriteLine("You are rolling " + usrInput[0] + " dice with " + usrInput[1] + " faces");
            
            string result = "";
            Random rand = new Random();
            for (int i = 0; i < rolled; i++)
            {
                result += "Roll " + (i + 1) + ": " + rand.Next(1, faces) + "\n";
            }
            Console.WriteLine(result.Substring(0, result.Length - 1));
        }
    }
}
