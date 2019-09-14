using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
            String[] numberList;
            numberList = Console.ReadLine().Split(", ".ToCharArray());
            
            foreach (String num in numberList)
            {
                if (num != "")
                {
                  int index =   Array.IndexOf(numberList, num);
                  int index2 = Array.IndexOf(numberList, num, index + 1);
                    if (index2 == -1)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
    }
}
