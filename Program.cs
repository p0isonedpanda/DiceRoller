using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your dice roll:");
            string[] usrInput = Console.ReadLine().Split("d");
            if (usrInput.Length < 2 || usrInput.Length > 3)
            {
                Console.WriteLine("Please use valid formatting");
                return;
            }
            
            int rolled, faces, modifier;
            if (usrInput[1].Split("+").Length == 2)
            {
                try
                {
                    rolled = Convert.ToInt32(usrInput[0]);
                    faces = Convert.ToInt32(usrInput[1].Split("+")[0]);
                    modifier = Convert.ToInt32(usrInput[1].Split("+")[1]);
                }
                catch
                {
                    Console.WriteLine("Please use valid formatting");
                    return;
                }
            }
            else if (usrInput[1].Split("-").Length == 2)
            {
                try
                {
                    rolled = Convert.ToInt32(usrInput[0]);
                    faces = Convert.ToInt32(usrInput[1].Split("-")[0]);
                    modifier = Convert.ToInt32(usrInput[1].Split("-")[1]) * -1;
                }
                catch
                {
                    Console.WriteLine("Please use valid formatting");
                    return;
                }
            }
            else
            {
                try
                {
                    rolled = Convert.ToInt32(usrInput[0]);
                    faces = Convert.ToInt32(usrInput[1]);
                    modifier = 0;
                }
                catch
                {
                    Console.WriteLine("Please use valid formatting");
                    return;
                }
            }

            string result = "";
            Random rand = new Random();
            for (int i = 0; i < rolled; i++)
            {
                result += "Roll " + (i + 1) + ": " + (rand.Next(1, faces) + modifier) + " (" + modifier + " modifier)\n";
            }
            Console.WriteLine(result.Substring(0, result.Length - 1));
        }
    }
}
