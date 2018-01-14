using System;
using System.Linq;

namespace SherlockAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                Console.WriteLine(solve(arr) ? "YES" : "NO");
            }
        }

        static bool solve(int[] A)
        {
            int LS = 0, RS = A.Sum();
            for(int i = 0; i < A.Length; i++)
            {
                RS -= A[i];
                if (LS == RS) return true;
                LS += A[i];
            }
            return false;
        }
    }
}
