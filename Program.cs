using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < q.Length; i++)
            {
                q[i] = i;
            }

           int t = GetNumber(20);
           Console.WriteLine(t);

        }
        static int[] q = new int[20];
        public static int GetNumber(int targetValue)
        {
            var min = 0;
            var max = q.Length - 1;
            int guess = 0;
            var counter = 0;

             while (max >= min) {
                counter++;
                guess = (int)Math.Floor((decimal)(max+min)/2);
                if (q[guess] == targetValue) {
                    return guess;
                } else if (q[guess] < targetValue) {
                    min = guess + 1;
                } else {
                    max = guess - 1;
                }
            }
            return 0;
        }
    }
}
