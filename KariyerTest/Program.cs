using System;
using System.Collections.Generic;
using System.Text;

namespace KariyerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Palindrome().Check("ABCCBA"));
            Console.WriteLine(new Palindrome().Check("ABCDCBA"));
            Console.WriteLine(new Palindrome().Check("EBCDCBA"));
            Console.WriteLine(new Palindrome().Check(""));


            WriteDublicateItem(new ArrayFunctions().GetDublicateCount(new int[] { 1, 2, 3, 5, 2, 3, 4, 1, 1 }));
            WriteDublicateItem(new ArrayFunctions().GetDublicateCount(new int[] { 1, 2 }));

            Console.ReadLine();
        }

        static void WriteDublicateItem(List<DublicateModel> dublicateList)
        {
            StringBuilder presenter = new StringBuilder();
            foreach (var item in dublicateList)
            {
                presenter.Append(item.Item.ToString());
                presenter.Append(" -> ");
                presenter.AppendLine("Count:" + item.Count);
            }
            Console.WriteLine(presenter);
        }
    }
}
