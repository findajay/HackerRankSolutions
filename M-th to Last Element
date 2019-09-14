using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
            int M = int.Parse(Console.ReadLine());

            int elem;

            LinkedList<int> L = new LinkedList<int>();
            String[] numberList;
            String line;

            line = Console.ReadLine();

            numberList = line.Split(" ".ToCharArray());
        if(numberList.Length < M)
            {
                Console.WriteLine("NIL");
            }
        else
          {
            foreach (string num in numberList)
            {
                elem = int.Parse(num);
                    L.AddLast(elem);
                if (L.Count > M)
                    L.RemoveFirst();
                 
            }

            int r = L.First.Value;

            if (r == -1)
                Console.WriteLine("NIL");
            else Console.WriteLine(r);
         }
    }
}
