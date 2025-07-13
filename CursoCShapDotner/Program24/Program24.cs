//using System.Globalization;
//using CursoC_Dotner.Program24.Entities;

//namespace CursoC_Dotner.Program24
//{
//    internal class Program24
//    {
//        static void Main(string[] args)
//        {
//            BusinessAccount account = new BusinessAccount(8010, "Paulo", 100.0, 500.0);

//            Console.WriteLine(account.Balance);

//            //erro
//            // account.Balance = 200.0; 

//            //abstract 
//            //Account acc = new Account(1001, "Alex", 0.0);
//            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

//            // UPCASTING

//            Account acc1 = bacc;
//            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
//            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

//            // DOWNCASTING

//            BusinessAccount acc4 = (BusinessAccount)acc2;
//            acc4.Loan(100.0);

//            //cuidado o DOWNCASTING e inseguro

//            // BusinessAccount acc5 = (BusinessAccount)acc3;
//            if (acc3 is BusinessAccount)
//            {
//                //BusinessAccount acc5 = (BusinessAccount)acc3;
//                BusinessAccount acc5 = acc3 as BusinessAccount;
//                acc5.Loan(200.0);
//                Console.WriteLine("Loan!");
//            }

//            if (acc3 is SavingsAccount)
//            {
//                //SavingsAccount acc5 = (SavingsAccount)acc3;
//                SavingsAccount acc5 = acc3 as SavingsAccount;
//                acc5.UpdateBalance();
//                Console.WriteLine("Update!");
//            }

//            // virtual override
//            //abstract 
//            // Account acc6 = new Account(1001, "Alex", 500.0);
//            Account acc6 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
//            Account acc7 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
//            acc6.Withdraw(10.0);
//            acc7.Withdraw(10.0);

//            Console.WriteLine(acc6.Balance);//Withdraw normal
//            Console.WriteLine(acc7.Balance);//Withdraw -5 


//            //abstract Account diferentes no mesmo array
//            List<Account> accounts = new List<Account>();
//            accounts.Add(new BusinessAccount(1003, "Bob", 10.0, 200.0));
//            accounts.Add(new SavingsAccount(1002, "Anna", 500.0, 0.01));
            
//            double sum = 0.0;
//            foreach (Account item in accounts)
//            {
//                sum += item.Balance;
                
//            }
//            Console.WriteLine($"Total Balance: {sum}");

//            foreach (Account item in accounts)
//            {
//               item.Withdraw(10.0);

//            }

//            foreach (Account item in accounts)
//            {
//                Console.WriteLine($"Update balance dor account {item.Number} : { item.Balance.ToString("F2",CultureInfo.InvariantCulture)}");

//            }
            
//        }

//    }
//}
