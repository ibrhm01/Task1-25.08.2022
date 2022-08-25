using System;
using Task1_25._08._2022.Models;

namespace Task1_25._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list1 = new MyList<int>(5);
            list1.Add(5);
            list1.Add(6);
            list1.Add(10);
            list1.Add(8);
            list1.Add(63);
            list1.Reverse();
            list1.Remove(10);
            list1.Clear();
            list1.Add(82);
            list1.Add(9);
            list1.Add(4);
            list1.Add(140);
            list1.Add(9);
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine("Value: "+ list1[i]);
            }
            Console.WriteLine("Exist: " + list1.Exist(56));
            Console.WriteLine("IndexOf: "+ list1.IndexOf(9));
            Console.WriteLine("LastIndexOf: " + list1.LastIndexOf(9));
            

        }
    }
    
}
