//using CursoC_Dotner.Program31.Entities;
//using CursoC_Dotner.Program31.Services;

//namespace CursoC_Dotner.Program31
//{
//    internal class Program31
//    {
//        static void Main(string[] args)
//        {
//            List<Product> list = new List<Product>();

//            list.Add(new Product("TV", 900.00));
//            list.Add(new Product("Notebook", 1200.00));
//            list.Add(new Product("Tablet", 450.00));

//            list.Sort(CompareProducts);

//            foreach (Product p in list)
//            {
//                Console.WriteLine(p);
//            }

//            Comparison<Product> comp = CompareProducts;

//            Comparison<Product> comp2 = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

//            list.Sort(comp);

//            foreach (Product p in list)
//            {
//                Console.WriteLine(p);
//            }

//            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

//            foreach (Product p in list)
//            {
//                Console.WriteLine(p);
//            }

//            Console.WriteLine("------------------------**//**------------------------------");


//            double a = 10;
//            double b = 12;

//            // double result = CalculationService.Sum(a, b);
//            // double result = CalculationService.Square(a);
//            double result = CalculationService.Max(a, b);
//            Console.WriteLine(result);

//            // BinaryNumericOperation op2 = CalculationService.Sum;
//            // BinaryNumericOperation op2 = CalculationService.Square;//erro
//            BinaryNumericOperation op2 = CalculationService.Max;
//            double result2 = op2(a, b);
//            Console.WriteLine(result2);

//            BinaryNumericOperation op3 = new BinaryNumericOperation(CalculationService.Sum);
//            double result3 = op3(a, b);
//            double result4 = op3.Invoke(a, b);
//            Console.WriteLine(result3);

//            BinaryNumericOperation2 op = CalculationService.ShowSum;
//            op += CalculationService.ShowMax;
//            op(a, b);

//            Console.WriteLine("------------------------**//**------------------------------");

//            List<Product> list2 = new List<Product>();
//            list2.Add(new Product("Tv", 900.00));
//            list2.Add(new Product("Mouse", 50.00));
//            list2.Add(new Product("Tablet", 350.50));
//            list2.Add(new Product("HD Case", 80.90));

//            list2.RemoveAll(p => p.Price >= 100.0);
//            list2.RemoveAll(ProductTest);

//            foreach (var p in list2)
//            {
//                Console.WriteLine(p);
//            }

//            list2.ForEach(UpdatePrice);

//            Action<Product> act = UpdatePrice;

//            Action<Product> act2 = p => { p.Price += p.Price * 0.1; };

//            list2.ForEach(act);
//            list2.ForEach(act2);
//            list2.ForEach(p =>  p.Price += p.Price * 0.1);

//            foreach (var p in list2)
//            {
//                Console.WriteLine(p);
//            }

//            List<string> result5 = list2.Select(NameUpper).ToList();

//            foreach (var s in result5)
//            {
//                Console.WriteLine(s);
//            }

//            Func<Product,string> func = NameUpper;

//            Func<Product, string> func2 = p => p.Name.ToUpper();

//            List<string> result6 = list2.Select(func).ToList();

//            List<string> result7 = list2.Select(p => p.Name.ToUpper()).ToList();

//            foreach (var s in result5)
//            {
//                Console.WriteLine(s);
//            }

//            foreach (var s in result6)
//            {
//                Console.WriteLine(s);
//            }


//            foreach (var s in result7)
//            {
//                Console.WriteLine(s);
//            }

//        }

//        static int CompareProducts(Product p1, Product p2)
//        {
//            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//        }

//        delegate double BinaryNumericOperation(double n1, double n2);
//        delegate void BinaryNumericOperation2(double n1, double n2);

//        public static bool ProductTest(Product p) {
//            return p.Price >= 100.0;
//        }

//        public static void UpdatePrice(Product p)
//        {
//            p.Price += p.Price * 0.1;
//        }

//        public static string NameUpper(Product p)
//        {
//            return p.Name.ToUpper();
//        }
//    }
//}
