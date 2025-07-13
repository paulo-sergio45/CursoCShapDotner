//using System.Globalization;
//using CursoC_Dotner.Program29.Entities;
//using CursoC_Dotner.Program29.Services;

//namespace CursoC_Dotner.Program28
//{
//    class Program29
//    {
//        static void Main(string[] args)
//        {
//            PrintService<int> printService = new PrintService<int>();

//            Console.Write("How many values? ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {
//                int x = int.Parse(Console.ReadLine());
//                printService.AddValue(x);
//            }

//            printService.Print();
//            Console.WriteLine("First: " + printService.First());

//            Console.WriteLine("******************//*****************");

//            List<Product> list = new List<Product>();

//            Console.Write("Enter the number of products: ");
//            int n1 = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n1; i++)
//            {
//                string[] vect = Console.ReadLine().Split(',');
//                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
//                list.Add(new Product(vect[0], price));
//            }

//            CalculationService calculationService = new CalculationService();

//            Product p = calculationService.Max(list); // <Product> is optional

//            Console.WriteLine("Most expensive:");
//            Console.WriteLine(p);

//            Console.WriteLine("******************//*****************");

//            string a = "Maria";
//            string b = "Alex";
//            Console.WriteLine(a.Equals(b));

//            string a2 = "Maria";
//            string b2 = "Alex";
//            Console.WriteLine(a2.GetHashCode());
//            Console.WriteLine(b2.GetHashCode());

//            Client client = new Client { Name = "paulo", Email = "paulo@gmail.com" };
//            Client client2 = new Client { Name = "maria", Email = "maria@gmail.com" };

//            Console.WriteLine(client.Equals(client2));
//            Console.WriteLine(client == client2);
//            Console.WriteLine(client.GetHashCode());
//            Console.WriteLine(client2.GetHashCode());

//            Console.WriteLine("******************//*****************");

//            HashSet<string> set = new HashSet<string>();
//            set.Add("TV");
//            set.Add("Notebook");
//            set.Add("Tablet");
//            Console.WriteLine(set.Contains("Notebook"));
//            foreach (string s in set)
//            {
//                Console.WriteLine(s);
//            }

//            Console.WriteLine("******************//*****************");

//            SortedSet<int> sset1 = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
//            SortedSet<int> sset2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
//            //union
//            SortedSet<int> sset3 = new SortedSet<int>(sset1);
//            sset3.UnionWith(sset2);
//            printCollection(sset3);
//            //intersection
//            SortedSet<int> sset4 = new SortedSet<int>(sset1);
//            sset4.IntersectWith(sset2);
//            printCollection(sset4);
//            //difference
//            SortedSet<int> sset5 = new SortedSet<int>(sset1);
//            sset5.ExceptWith(sset2);
//            printCollection(sset5);

//            Console.WriteLine("******************//*****************");

//            HashSet<Product> product = new HashSet<Product>();
//            product.Add(new Product("TV", 900.0));
//            product.Add(new Product("Notebook", 1200.0));

//            HashSet<Point> product2 = new HashSet<Point>();
//            product2.Add(new Point(3, 4));
//            product2.Add(new Point(5, 10));

//            Product prod = new Product("Notebook", 1200.0);

//            Console.WriteLine(product.Contains(prod));

//            Point point = new Point(5, 10);

//            Console.WriteLine(product2.Contains(point));

//            Console.WriteLine("******************//*****************");

//            Dictionary<string, string> cookies = new Dictionary<string, string>();
//            cookies["user"] = "maria";
//            cookies["email"] = "maria@gmail.com";
//            cookies["phone"] = "99771122";
//            cookies["phone"] = "99771133";
//            Console.WriteLine(cookies["email"]);
//            cookies.Remove("email");
//            Console.WriteLine("Phone number: " + cookies["phone"]);
//            if (cookies.ContainsKey("email"))
//            {
//                Console.WriteLine("Email: " + cookies["email"]);
//            }
//            else
//            {
//                Console.WriteLine("There is not 'email' key");
//            }
//            Console.WriteLine("Size: " + cookies.Count);
//            Console.WriteLine("ALL COOKIES:");
//            foreach (var item in cookies)
//            //   foreach (KeyValuePair<string, string> item in cookies)
//            {
//                Console.WriteLine(item.Key + ": " + item.Value);
//            }

//        }

//        static void printCollection<T>(IEnumerable<T> collection)
//        {
//            foreach (T obj in collection)
//            {
//                Console.Write(obj + " ");
//            }
//            Console.WriteLine();
//        }

//    }
//}
//using System.Globalization;
//using CursoC_Dotner.Program29.Entities;
//using CursoC_Dotner.Program29.Services;

//namespace CursoC_Dotner.Program28
//{
//    class Program29
//    {
//        static void Main(string[] args)
//        {
//            PrintService<int> printService = new PrintService<int>();

//            Console.Write("How many values? ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {
//                int x = int.Parse(Console.ReadLine());
//                printService.AddValue(x);
//            }

//            printService.Print();
//            Console.WriteLine("First: " + printService.First());

//            Console.WriteLine("******************//*****************");

//            List<Product> list = new List<Product>();

//            Console.Write("Enter the number of products: ");
//            int n1 = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n1; i++)
//            {
//                string[] vect = Console.ReadLine().Split(',');
//                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
//                list.Add(new Product(vect[0], price));
//            }

//            CalculationService calculationService = new CalculationService();

//            Product p = calculationService.Max(list); // <Product> is optional

//            Console.WriteLine("Most expensive:");
//            Console.WriteLine(p);

//            Console.WriteLine("******************//*****************");

//            string a = "Maria";
//            string b = "Alex";
//            Console.WriteLine(a.Equals(b));

//            string a2 = "Maria";
//            string b2 = "Alex";
//            Console.WriteLine(a2.GetHashCode());
//            Console.WriteLine(b2.GetHashCode());

//            Client client = new Client { Name = "paulo", Email = "paulo@gmail.com" };
//            Client client2 = new Client { Name = "maria", Email = "maria@gmail.com" };

//            Console.WriteLine(client.Equals(client2));
//            Console.WriteLine(client == client2);
//            Console.WriteLine(client.GetHashCode());
//            Console.WriteLine(client2.GetHashCode());

//            Console.WriteLine("******************//*****************");

//            HashSet<string> set = new HashSet<string>();
//            set.Add("TV");
//            set.Add("Notebook");
//            set.Add("Tablet");
//            Console.WriteLine(set.Contains("Notebook"));
//            foreach (string s in set)
//            {
//                Console.WriteLine(s);
//            }

//            Console.WriteLine("******************//*****************");

//            SortedSet<int> sset1 = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
//            SortedSet<int> sset2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
//            //union
//            SortedSet<int> sset3 = new SortedSet<int>(sset1);
//            sset3.UnionWith(sset2);
//            printCollection(sset3);
//            //intersection
//            SortedSet<int> sset4 = new SortedSet<int>(sset1);
//            sset4.IntersectWith(sset2);
//            printCollection(sset4);
//            //difference
//            SortedSet<int> sset5 = new SortedSet<int>(sset1);
//            sset5.ExceptWith(sset2);
//            printCollection(sset5);

//            Console.WriteLine("******************//*****************");

//            HashSet<Product> product = new HashSet<Product>();
//            product.Add(new Product("TV", 900.0));
//            product.Add(new Product("Notebook", 1200.0));

//            HashSet<Point> product2 = new HashSet<Point>();
//            product2.Add(new Point(3, 4));
//            product2.Add(new Point(5, 10));

//            Product prod = new Product("Notebook", 1200.0);

//            Console.WriteLine(product.Contains(prod));

//            Point point = new Point(5, 10);

//            Console.WriteLine(product2.Contains(point));

//            Console.WriteLine("******************//*****************");

//            Dictionary<string, string> cookies = new Dictionary<string, string>();
//            cookies["user"] = "maria";
//            cookies["email"] = "maria@gmail.com";
//            cookies["phone"] = "99771122";
//            cookies["phone"] = "99771133";
//            Console.WriteLine(cookies["email"]);
//            cookies.Remove("email");
//            Console.WriteLine("Phone number: " + cookies["phone"]);
//            if (cookies.ContainsKey("email"))
//            {
//                Console.WriteLine("Email: " + cookies["email"]);
//            }
//            else
//            {
//                Console.WriteLine("There is not 'email' key");
//            }
//            Console.WriteLine("Size: " + cookies.Count);
//            Console.WriteLine("ALL COOKIES:");
//            foreach (var item in cookies)
//            //   foreach (KeyValuePair<string, string> item in cookies)
//            {
//                Console.WriteLine(item.Key + ": " + item.Value);
//            }

//        }

//        static void printCollection<T>(IEnumerable<T> collection)
//        {
//            foreach (T obj in collection)
//            {
//                Console.Write(obj + " ");
//            }
//            Console.WriteLine();
//        }

//    }
//}
