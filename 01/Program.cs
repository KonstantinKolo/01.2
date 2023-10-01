using System;
using System.Linq;

namespace _01 {
    class Program {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  //О(n)
            int minimum = arr[0];                                                   //O(1)

            foreach(var item in arr) {                                              //O(n)
                if (minimum > item)                                                 //O(1)
                    minimum = item;                                                 //O(1)
            }
                
            Console.WriteLine("Smalest number is " + minimum);                      //O(1)

            //Complexity of algorithm is O(n)
        }
    }
}
