using System;

namespace GC_class916
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? Y or N");
                string input1;
                
                input1 = Console.ReadLine();
                input1 = input1.ToLower();

                if (input1 == "y")
                {
                    Console.Write("How many sides should the dice have?");
                    string input2 = Console.ReadLine();
                    int.Parse(input2);

                    Random rndm = new Random();

                    int num = int.Parse(input2);
                    int min = 1;
                    int max = num;

                    int i = 0;
                    while (i < num)
                    {
                        Console.WriteLine(rndm.Next(min, max));
                        i++;
                    }

                    Console.WriteLine("Roll again? Y or N");
                    string answer;

                    answer = Console.ReadLine();
                    answer = answer.ToLower();

                    if (answer == "y")
                    {
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }

                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}
