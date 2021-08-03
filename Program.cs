using System;

namespace teste
{
    class Program
    {
        static int[] q = new int[20];

        static void Main(string[] args)
        {
            Random random = new Random();
            for(int i = 0; i < q.Length; i++)
            {
                q[i] = random.Next();
            }

            Array.Sort(q);

           int t = GetNumber(q[19]);
           Console.WriteLine(t);

        }
        public static int GetNumber(int targetValue)
        {
            var min = 0;
            var max = q.Length - 1;
            int guess = 0;
            var counter = 0;

             while (max >= min) 
             {
                counter++;
                guess = (int)Math.Floor((decimal)(max+min)/2);
                if (q[guess] == targetValue) 
                {
                    return guess;
                } else if (q[guess] < targetValue) 
                {
                    min = guess + 1;
                } else 
                {
                    max = guess - 1;
                }
            }
            return 0;
        }
    }
}
