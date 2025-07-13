//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program21
//{
//    internal class Program21
//    {
//        static void Main(string[] args)
//        {

//            string[] vect = new string[] { "teste1", "teste2", "teste3" };

//            for (int i = 0; i < vect.Length; i++)
//            {
//                Console.WriteLine(vect[i]);

//            }

//            Console.WriteLine("-------------------------------------");

//            foreach (string item in vect)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");

//            List<string> list = new List<string>();

//            List<string> list2 = new List<string> { "teste1", "teste2", "teste3" };

//            list.Add("AnaMaria");
//            list.Add("paulo1");
//            list.Add("paulo2");
//            list.Add("paulo3");
//            list.Add("paulo4");
//            list.Insert(2, "paulo5");
//            list.Insert(2, "paulo6");
//            list.Insert(list.Count, "Ana");
//            list.Add("paulo4");



//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("______________________________________");
//            Console.WriteLine("list.Count=" + list.Count);

//            string s1 = list.Find(Test);
//            Console.WriteLine("first 'A': " + s1);

//            string s2 = list.Find((x) => x.Contains("2"));
//            Console.WriteLine("Contains '2': " + s2);


//            string s3 = list.FindLast((x) => x[0] == 'A');
//            Console.WriteLine("last 'A': " + s3);


//            int s4 = list.FindIndex((x) => x[0] == 'A');
//            Console.WriteLine("index first 'A': " + s4);


//            int s5 = list.FindLastIndex((x) => x[0] == 'A');
//            Console.WriteLine("index last 'A': " + s5);

//            List<string> s6 = list.FindAll((x) => x.Length == 6);

//            Console.WriteLine("Length 6 : ");
//            foreach (var item in s6)
//            {

//                Console.WriteLine("--- " + item);
//            }


//            Console.WriteLine("______________________________________");
//            list.Remove("paulo3");
//            Console.WriteLine("Remove paulo3: ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");
//            list.RemoveAll(x => x[0] == 'A');
//            Console.WriteLine("Remove all first 'A': ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");
//            list.RemoveAt(2);
//            Console.WriteLine("RemoveAt 2: ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");
//            list.RemoveRange(2,3);
//            Console.WriteLine("RemoveRange 2,2: ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//        }
//        static bool Test(string s)
//        {
//            return s[0] == 'A';
//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program21
//{
//    internal class Program21
//    {
//        static void Main(string[] args)
//        {

//            string[] vect = new string[] { "teste1", "teste2", "teste3" };

//            for (int i = 0; i < vect.Length; i++)
//            {
//                Console.WriteLine(vect[i]);

//            }

//            Console.WriteLine("-------------------------------------");

//            foreach (string item in vect)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");

//            List<string> list = new List<string>();

//            List<string> list2 = new List<string> { "teste1", "teste2", "teste3" };

//            list.Add("AnaMaria");
//            list.Add("paulo1");
//            list.Add("paulo2");
//            list.Add("paulo3");
//            list.Add("paulo4");
//            list.Insert(2, "paulo5");
//            list.Insert(2, "paulo6");
//            list.Insert(list.Count, "Ana");
//            list.Add("paulo4");



//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("______________________________________");
//            Console.WriteLine("list.Count=" + list.Count);

//            string s1 = list.Find(Test);
//            Console.WriteLine("first 'A': " + s1);

//            string s2 = list.Find((x) => x.Contains("2"));
//            Console.WriteLine("Contains '2': " + s2);


//            string s3 = list.FindLast((x) => x[0] == 'A');
//            Console.WriteLine("last 'A': " + s3);


//            int s4 = list.FindIndex((x) => x[0] == 'A');
//            Console.WriteLine("index first 'A': " + s4);


//            int s5 = list.FindLastIndex((x) => x[0] == 'A');
//            Console.WriteLine("index last 'A': " + s5);

//            List<string> s6 = list.FindAll((x) => x.Length == 6);

//            Console.WriteLine("Length 6 : ");
//            foreach (var item in s6)
//            {

//                Console.WriteLine("--- " + item);
//            }


//            Console.WriteLine("______________________________________");
//            list.Remove("paulo3");
//            Console.WriteLine("Remove paulo3: ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");
//            list.RemoveAll(x => x[0] == 'A');
//            Console.WriteLine("Remove all first 'A': ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");
//            list.RemoveAt(2);
//            Console.WriteLine("RemoveAt 2: ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("______________________________________");
//            list.RemoveRange(2,3);
//            Console.WriteLine("RemoveRange 2,2: ");
//            foreach (string item in list)
//            {
//                Console.WriteLine(item);
//            }

//        }
//        static bool Test(string s)
//        {
//            return s[0] == 'A';
//        }
//    }
//}
