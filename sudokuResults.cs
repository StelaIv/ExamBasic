using System;

namespace _02.SudocuResults
{
    class sudokuResults
    {
        static void Main()
        {
            double counter = 0;
            double sum = 0;
            for (int i = 0; ; i++)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(':');
                if (input == "Quit")
                {
                    break;
                }

                counter++;
                var minutes = Convert.ToInt32(splitInput[0]) * 60;
                var sec = Convert.ToInt32(splitInput[1]);
                sum += (minutes + sec);
            }

            int result;
            if (sum % counter >= 1)
            {
                result = (int)(sum / counter) + 1;

            }
            else
            {
                result = (int)(sum / counter);
            }

            if (result < 720)
            {
                Console.WriteLine("Gold Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, result);

            }
            else if (result >= 720 && result <= 1440)
            {
                Console.WriteLine("Silver Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, result);
            }
            else
            {
                Console.WriteLine("Bronze Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, result);
            }
        }
    }
}
