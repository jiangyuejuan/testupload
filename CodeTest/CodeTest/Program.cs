using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] processArray = new int[] { 37, 37, 37, 37, 0, 0, 0, 0, 37, 0, 0, 39, 0, 0, 40, 0, 0, 40, 0, 0, 39, 0, 38, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < processArray.Length; i++)
            {
                if (processArray[i] == 0 && i>0)
                {
                    processArray[i] = processArray[i - 1];
                }
            }

            for (int i = 0; i < processArray.Length; i++)
            {
                Console.WriteLine(processArray[i]);
            }

            //var TargetGroupIDList = new List<string>();
            //for (int i = 0; i < 250; i++)
            //{
            //    TargetGroupIDList.Add((i + 1).ToString());
            //}

            //List<List<string>> listGroup = new List<List<string>>();
            //int j = 50;
            //for (int i = 0; i < TargetGroupIDList.Count; i += 50)
            //{
            //    List<string> cList = new List<string>();
            //    cList = TargetGroupIDList.Take(j).Skip(i).ToList();
            //    listGroup.Add(cList);
            //    j += 50;

            //}


            Hashtable ht = new Hashtable();
            HashSet<string> hs = new HashSet<string>();
            //int iCount = 0;
            //int temp = 0;
            //int[] intArray = new int[9] { 4, 5, 2, 34, 45, 5, 3, 54, 42 };
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    if ((intArray[i] ^ intArray[i + 1]) == 1)
            //    {
            //        temp = intArray[i];
            //        ++iCount;
            //    }
            //}

           // Console.WriteLine(temp);

            int a = 3;
            int b = 1;
            a = a + b;
            b = a - b;
            a = a - b;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            
            Console.WriteLine(a);
            Console.WriteLine(b);



            var set = new HashSet<int>() { 5, 9, 2, 1, 2, 2, 3, 7, 4, 9, 9 };
            foreach (int element in set)
                Console.WriteLine(element);

            var set1 = new SortedSet<int>() { 5, 9, 2, 1, 2, 2, 3, 7, 4, 9, 9 };
            foreach (int element in set1)
                Console.WriteLine(element);

            //Node a = new Node("A");
            //Node b = new Node("B");
            //Node c = new Node("C");
            //Node d = new Node("D");
            //Node e = new Node("E");
            //Node f = new Node("F");
            //Node g = new Node("G");
            //Node h = new Node("H");
            //a.Left = b;
            //a.Right = c;

            //b.Left = d;
            //b.Right = e;
            //c.Left = f;
            //c.Right = g;
            //d.Left = h;

            IntMethod();
            MethodString();
            int[] array = new int[10] {44,45,3,4,5,6,32,46,43,1};
            FindMaxAndMin(array);
            Console.ReadKey();
        }

        static void FindMaxAndMin(int[] arraySend)
        {
            //int[] Array = arraySend;
            int imax = 0;
            int imin = 0;
            for (int i = 0; i < arraySend.Length-1; i++)
            {
                if (arraySend[i] < arraySend[i + 1])
                {
                    imax = arraySend[i + 1];
                }
                else
                {

                    imin = arraySend[i + 1];
                }                
            }

            Console.WriteLine(imin);
            Console.WriteLine(imax);
        }


        static void IntMethod()
        {
            int count = 1000000;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < count; i++)
            {
                dictionary.Add(i, i);
                hashtable.Add(i, i);
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                int value = dictionary[i];
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                object value = hashtable[i];
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);

        }

        static void MethodString()
        {
            int count = 1000000;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < count; i++)
            {
                dictionary.Add(i.ToString(), "aaa");
                hashtable.Add(i.ToString(), "aaa");
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                string value = dictionary[i.ToString()];
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                object value = hashtable[i.ToString()];
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private void FindNode(Node send)
        {
            if (send == null) return;
            if (send.Left != null) FindNode(send);
            if (send.Right != null) FindNode(send);
           // if (send.Right != null) FindNode(send);
        }

        public class Node
        {

            public Node(string name)
            {
                this.Value = name;
            }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public string Value { get; set; }
        }
    }
}
