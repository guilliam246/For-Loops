using System;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var numbers  = new int[] {1, 2, 3,4 };

          foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
               
        }
    }
}
