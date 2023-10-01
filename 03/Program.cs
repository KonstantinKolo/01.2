using System;
using System.Collections.Generic;
using System.Linq;

namespace _03 {
    class Program {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList(); //O(n)
            string helper;                                              //O(1)

            for (int i = 0; i < list.Count - 1; i++) {                  //O(n)
                for (int j = i + 1; j < list.Count; j++) {              //O(n^2)
                    if (list[i][0] > list[j][0]) {                      //O(n)
                        helper = list[i];                               //O(n)
                        list[i] = list[j];                              //O(n)
                        list[j] = helper;                               //O(n)
                    }
                }
            }

            Console.WriteLine(string.Join(" ",list));                   //O(1)

            //Complexity of algorithm is O(n^2)
        }
    }
}
