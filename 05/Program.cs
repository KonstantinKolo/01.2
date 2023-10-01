using System;
using System.Collections.Generic;
using System.Linq;

namespace _05 {
    class Program {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();  //O(n)
            List<int> finalList = new List<int>();
            list.Sort();    //O(n^2)

            int num = int.Parse(Console.ReadLine());    //O(1)
            bool isWriten = false;

            if (list.Contains(num)) {
                for (int i = 0; i < list.Count; i++) {
                    if (num == list[i])
                        continue;

                    finalList.Add(list[i]);
                }
            }
            else {
                for(int i = 0; i < list.Count; i++) {
                    if (num < list[i] && isWriten == false) {
                        finalList.Add(num);
                        isWriten = true;
                    }

                    finalList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
