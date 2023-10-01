using System;
using System.Collections.Generic;
using System.Linq;

namespace _04 {
    class Program {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();     //O(n)
            List<int> finalList = new List<int>();      //O(1)
            int num = inputList[0];     //O(1)
            int counter = 1;    //O(1)
            int longest = 1;    //O(1)

            for (int i = 0; i < inputList.Count - 1; i++) {     //O(n)
                if (inputList[i] == inputList[i + 1])  {        //O(n)
                    counter++;                                  //O(n)
                }
                else {                                          //O(n)
                    counter = 1;                                //O(n)
                }

                if(counter > longest) {                         //O(n)
                    num = inputList[i];                         //O(n)
                    longest = counter;                          //O(n)
                }
            }

            for(int i = 0; i < longest; i++) {                  //O(n)
                finalList.Add(num);                             //O(n)
            }

            Console.WriteLine(string.Join(" ",finalList));      //O(1)

            //Complexity of algorithm is O(n)
        }
    }
}
