using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day2
{
    class CollectionDemo
    {

        static void ArrayEg() //can have heterogeneous data types
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Capacity:{0}", al.Capacity);
            al.Add(10);
            al.Add("Devi");
            Console.WriteLine("Capacity:{0}", al.Capacity);
            al.Add("100.0f");
            Console.WriteLine("Capacity:{0}", al.Capacity);
            al.Add('A');
            Console.WriteLine("Capacity:{0}", al.Capacity);
            al.Add(20);
            Console.WriteLine("Capacity:{0}", al.Capacity);
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }

            Console.WriteLine("count is {0}", al.Count);
            Console.WriteLine("index of is{0}", al.IndexOf(20));
            Console.WriteLine("Capacity:{0}", al.Capacity);
            al.Remove("Devi");
            al.Remove(20);
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            Console.WriteLine("Capacity:{0}", al.Capacity);

        }

        //combination of keys and values
        static void HashtableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("N", "Networks");
            ht.Add("O", "Operating Systems");
            ht.Add("J", "Java");

            ht.Add("U", "Unix");
            Console.WriteLine(ht.Contains("o"));

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
        }

        static void SortedlistEg() //similar to hash table but in sorted order
        {
            SortedList s1 = new SortedList();
            s1.Add("B", "Networks");
            s1.Add("A", "Operating Systems");
            s1.Add("C", "Java");

            s1.Add("H", "Unix");

            foreach( DictionaryEntry d in s1)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }

        }

        /* Stack<int> myStack = new Stack<int>();
         int[] arr = new int[]{ 1, 2, 3, 4};
Stack<int> myStack = new Stack<int>(arr); LIFO*/

        /* Queue q = new Queue(); FIFO*/


        static void Main()
        {
            ArrayEg();
            Console.WriteLine("Hash table");
            HashtableEg();
            Console.WriteLine("Sorted list");
            SortedlistEg();
        }
    }
}
