//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program22
//{
//    internal class Program22
//    {
//        static void Main(string[] args)
//        {
//            double[,] mat = new double[2, 3];

//            Console.WriteLine(mat.Length);
//            Console.WriteLine(mat.Rank);
//            Console.WriteLine(mat.GetLength(0));
//            Console.WriteLine(mat.GetLength(1));


//            var x = 10;
//            var y = 20;
//            var z = "maria";

//            var w1 = z;
//            //int w2 = z;

//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(z);

//            Console.WriteLine("****************************//**********************************");

//            int n = int.Parse(Console.ReadLine());

//            string day;

//            if (n == 1)
//            {
//                day = "sunday";

//            }
//            else if (n == 2)
//            {
//                day = "Monday";

//            }
//            else if (n == 3)
//            {
//                day = "Tuesday";

//            }
//            else if (n == 4)
//            {
//                day = "Wednesday";

//            }
//            else if (n == 5)
//            {
//                day = "Thursday";

//            }
//            else if (n == 6)
//            {
//                day = "Friday";

//            }
//            else if (n == 7)
//            {
//                day = "Saturday";

//            }
//            else
//            {
//                day = "Invalid value";

//            }

//            Console.WriteLine("Day: " + day);
//            Console.WriteLine("****************************//**********************************");

//            switch (n)
//            {
//                case 1:

//                    day = "sunday";
//                    break;
//                case 2:

//                    day = "Monday";
//                    break;
//                case 3:

//                    day = "Tuesday";
//                    break;

//                case 4:
//                    day = "Wednesday";
//                    break;

//                case 5:
//                    day = "Thursday";
//                    break;

//                case 6:
//                    day = "Friday";
//                    break;
//                case 7:

//                    day = "Saturday";
//                    break;

//                default:
//                    day = "Invalid value";
//                    break;
//            }
//            Console.WriteLine("Day: " + day);

//            Console.WriteLine("****************************//**********************************");

//            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            double desconto1;
//            if (preco < 20.0)
//            {
//                desconto1 = preco * 0.1;
//            }
//            else
//            {
//                desconto1 = preco * 0.05;
//            }

//            Console.WriteLine("desconto: " + desconto1);

//            double desconto2 = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

//            Console.WriteLine("desconto: " + desconto2);

//            Console.WriteLine("****************************//**********************************");


//            string original = "abcde FGHIJ ABC abc DEFG ";
//            string s1 = original.ToUpper();
//            string s2 = original.ToLower();
//            string s3 = original.Trim();
//            int n1 = original.IndexOf("bc");
//            int n2 = original.LastIndexOf("bc");
//            string s4 = original.Substring(3);
//            string s5 = original.Substring(3, 5);
//            string s6 = original.Replace('a', 'x');
//            string s7 = original.Replace("abc", "xy");
//            bool b1 = String.IsNullOrEmpty(original);
//            bool b2 = String.IsNullOrWhiteSpace(original);
//            Console.WriteLine("Original: -" + original + "-");
//            Console.WriteLine("ToUpper: -" + s1 + "-");
//            Console.WriteLine("ToLower: -" + s2 + "-");
//            Console.WriteLine("Trim: -" + s3 + "-");
//            Console.WriteLine("IndexOf('bc'): " + n1);
//            Console.WriteLine("LastIndexOf('bc'): " + n2);
//            Console.WriteLine("Substring(3): -" + s4 + "-");
//            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
//            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
//            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
//            Console.WriteLine("IsNullOrEmpty: " + b1);
//            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

//            Console.WriteLine("****************************//**********************************");

//            DateTime d1 = new DateTime(2000, 8, 15);
//            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
//            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

//            DateTime d4 = DateTime.Now;
//            DateTime d5 = DateTime.UtcNow;
//            DateTime d6 = DateTime.Today;

//            DateTime d7 = DateTime.Parse("2000-08-15");
//            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
//            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
//            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
//            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

//            Console.WriteLine(d1);
//            Console.WriteLine(d1.Ticks);
//            Console.WriteLine(d2);
//            Console.WriteLine(d3);

//            Console.WriteLine(d4);
//            Console.WriteLine(d5);
//            Console.WriteLine(d6);

//            Console.WriteLine(d7);
//            Console.WriteLine(d8);
//            Console.WriteLine(d9);
//            Console.WriteLine(d10);
//            Console.WriteLine(d11);


//            Console.WriteLine("****************************//**********************************");

//            TimeSpan t1 = new TimeSpan(0, 1, 30);

//            TimeSpan t2 = new TimeSpan();
//            TimeSpan t3 = new TimeSpan(900000000L);
//            TimeSpan t4 = new TimeSpan(2, 11, 21);
//            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
//            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

//            TimeSpan t7 = TimeSpan.FromDays(1.5);
//            TimeSpan t8 = TimeSpan.FromHours(1.5);
//            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
//            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
//            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
//            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

//            Console.WriteLine(t1);
//            Console.WriteLine(t1.Ticks);
//            Console.WriteLine(t2);
//            Console.WriteLine(t3);
//            Console.WriteLine(t4);
//            Console.WriteLine(t5);
//            Console.WriteLine(t6);

//            Console.WriteLine(t7);
//            Console.WriteLine(t8);
//            Console.WriteLine(t9);
//            Console.WriteLine(t10);
//            Console.WriteLine(t11);
//            Console.WriteLine(t12);

//            Console.WriteLine("****************************//**********************************");

//            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

//            Console.WriteLine(d);
//            Console.WriteLine("1) Date: " + d.Date);
//            Console.WriteLine("2) Day: " + d.Day);
//            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
//            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
//            Console.WriteLine("5) Hour: " + d.Hour);
//            Console.WriteLine("6) Kind: " + d.Kind);
//            Console.WriteLine("7) Millisecond: " + d.Millisecond);
//            Console.WriteLine("8) Minute: " + d.Minute);
//            Console.WriteLine("9) Month: " + d.Month);
//            Console.WriteLine("10) Second: " + d.Second);
//            Console.WriteLine("11) Ticks: " + d.Ticks);
//            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
//            Console.WriteLine("13) Year: " + d.Year);


//            string date1 = d.ToLongDateString();
//            string date2 = d.ToLongTimeString();
//            string date3 = d.ToShortDateString();
//            string date4 = d.ToShortTimeString();
//            string date5 = d.ToString();
//            string date6 = d.ToString("yyyy-MM-dd HH:mm:ss");
//            string date7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

//            Console.WriteLine(date1);
//            Console.WriteLine(date2);
//            Console.WriteLine(date3);
//            Console.WriteLine(date4);
//            Console.WriteLine(date5);
//            Console.WriteLine(date6);
//            Console.WriteLine(date7);


//            Console.WriteLine("****************************//**********************************");

//            TimeSpan timeSpan = new TimeSpan(1, 30, 10);
//            DateTime date = new DateTime(1992, 12, 10);


//            DateTime y1 = d.Add(timeSpan);
//            DateTime y2 = d.AddDays(2);
//            DateTime y3 = d.AddHours(5);
//            DateTime y4 = d.AddMilliseconds(100);
//            DateTime y5 = d.AddMinutes(1);
//            DateTime y6 = d.AddMonths(5);
//            DateTime y7 = d.AddSeconds(8);
//            DateTime y8 = d.AddTicks(9);
//            DateTime y9 = d.AddYears(100);
//            DateTime y10 = d.Subtract(timeSpan);
//            TimeSpan time = d.Subtract(date);


//            Console.WriteLine(date);
//            Console.WriteLine(timeSpan);
//            Console.WriteLine(y1);
//            Console.WriteLine(y2);
//            Console.WriteLine(y3);
//            Console.WriteLine(y4);
//            Console.WriteLine(y6);
//            Console.WriteLine(y7);
//            Console.WriteLine(y8);
//            Console.WriteLine(y9);
//            Console.WriteLine(y10);
//            Console.WriteLine(time);

//            Console.WriteLine("****************************//**********************************");

//            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
//            Console.WriteLine(t);
//            Console.WriteLine("Days: " + t.Days);
//            Console.WriteLine("Hours: " + t.Hours);
//            Console.WriteLine("Minutes: " + t.Minutes);
//            Console.WriteLine("Milliseconds: " + t.Milliseconds);
//            Console.WriteLine("Seconds: " + t.Seconds);
//            Console.WriteLine("Ticks: " + t.Ticks);
//            Console.WriteLine("TotalDays: " + t.TotalDays);
//            Console.WriteLine("TotalHours: " + t.TotalHours);
//            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
//            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
//            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);



//            TimeSpan time1 = new TimeSpan(1, 30, 10);
//            TimeSpan time2 = new TimeSpan(0, 10, 5);
//            TimeSpan sum = time1.Add(time2);
//            TimeSpan dif = time1.Subtract(time2);
//            TimeSpan mult = time2.Multiply(2.0);
//            TimeSpan div = time2.Divide(2.0);
//            Console.WriteLine(time1);
//            Console.WriteLine(time2);
//            Console.WriteLine(sum);
//            Console.WriteLine(dif);
//            Console.WriteLine(mult);
//            Console.WriteLine(div);

//            Console.WriteLine("****************************//**********************************");

//            DateTime datetime1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
//            DateTime datetime2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
//            DateTime datetime3 = new DateTime(2000, 8, 15, 13, 5, 58);
//            Console.WriteLine("datetime1: " + datetime1);
//            Console.WriteLine("datetime1 Kind: " + datetime1.Kind);
//            Console.WriteLine("datetime1 to Local: " + datetime1.ToLocalTime());
//            Console.WriteLine("datetime1 to Utc: " + datetime1.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine("datetime2: " + datetime2);
//            Console.WriteLine("datetime2 Kind: " + datetime2.Kind);
//            Console.WriteLine("datetime2 to Local: " + datetime2.ToLocalTime());
//            Console.WriteLine("datetime2 to Utc: " + datetime2.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine("datetime3: " + datetime3);
//            Console.WriteLine("datetime3 Kind: " + datetime3.Kind);
//            Console.WriteLine("datetime3 to Local: " + datetime3.ToLocalTime());
//            Console.WriteLine("datetime3 to Utc: " + datetime3.ToUniversalTime());

//            Console.WriteLine("****************************//**********************************");

//            DateTime datetime4 = DateTime.Parse("2000-08-15 13:05:58");
//            DateTime datetime5 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
//            Console.WriteLine("datetime4: " + datetime4);
//            Console.WriteLine("datetime4 Kind: " + datetime4.Kind);
//            Console.WriteLine("datetime4 to Local: " + datetime4.ToLocalTime());
//            Console.WriteLine("datetime4 to Utc: " + datetime4.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine("datetime5: " + datetime5);
//            Console.WriteLine("datetime5 Kind: " + datetime5.Kind);
//            Console.WriteLine("datetime5 to Local: " + datetime5.ToLocalTime());
//            Console.WriteLine("datetime5 to Utc: " + datetime5.ToUniversalTime());
//            Console.WriteLine();
//            Console.WriteLine(datetime5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
//            Console.WriteLine(datetime5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

//        }
//    }
//}
