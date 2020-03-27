using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab1
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n == 2)
                return true;
            if (n == 1 || n % 2 == 0)
                return false;
            for (int i = 3; i < Math.Sqrt(n); i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static int FirstAlgorithm(int n)
        {
            for (int i = n - 1; i > 1; i--)
            {
                if (isPrime(i))
                    return i;
            }

            return 0;
        }

        static int SecondAlgorithm(int n)
        {
            List<int> ciur = new List<int>();
            for (int i = 3; i < n; i+=2)
            {
                ciur.Add(i);
            }


            for (int i = 0; i < ciur.Count; i++)
            {
                for (int j = i+1; j < ciur.Count; j++)
                {
                    if (ciur[j] % ciur[i] == 0)
                    {

                        ciur.RemoveAt(j);
                    }
                    
                }
            }

            Console.Write(ciur.Max());
            return ciur.Max();
        }

        static void Mainn(string[] args)
        {


            Console.WriteLine(FirstAlgorithm(5000));
            SecondAlgorithm(5000);
        }
    }
}
