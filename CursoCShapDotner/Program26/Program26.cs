//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoC_Dotner.Program26
//{
//    class Program26
//    {
//        static void Main(string[] args)
//        {
//            string sourcePath = @"c:\temp\file1.txt";
//            string targetPath = @"c:\temp\file2.txt";
//            try
//            {
//                FileInfo fileInfo = new FileInfo(sourcePath);
//                fileInfo.CopyTo(targetPath);
//                string[] lines = File.ReadAllLines(sourcePath);
//                foreach (string line in lines)
//                {
//                    Console.WriteLine(line);
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }

//            Console.WriteLine("________________________________**_________________________________");

//            string path = @"c:\temp\file1.txt";
//            FileStream fs = null;
//            StreamReader sr = null;
//            try
//            {
//                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
//                sr = new StreamReader(fs);
//                string line = sr.ReadLine();
//                Console.WriteLine(line);
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                if (sr != null) sr.Close();
//                if (fs != null) fs.Close();
//            }

//            Console.WriteLine("________________________________**_________________________________");

//            StreamReader sr1 = null;
//            try
//            {
//                sr1 = File.OpenText(path);
//                while (!sr1.EndOfStream)
//                {
//                    string line = sr1.ReadLine();
//                    Console.WriteLine(line);
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }
//            finally
//            {
//                if (sr1 != null) sr1.Close();
//            }

//            Console.WriteLine("________________________________**_________________________________");

//            try
//            {
//                using (FileStream fs1 = new FileStream(path, FileMode.Open))
//                {
//                    using (StreamReader sr2 = new StreamReader(fs1))
//                    {
//                        string line = sr2.ReadLine();
//                        Console.WriteLine(line);
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }

//            Console.WriteLine("________________________________**_________________________________");

//            try
//            {
//                using (StreamReader sr3 = File.OpenText(path))
//                {
//                    while (!sr3.EndOfStream)
//                    {
//                        string line = sr3.ReadLine();
//                        Console.WriteLine(line);
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }

//            Console.WriteLine("________________________________**_________________________________");
           
//            string sourcePath1 = @"c:\temp\file1.txt";
//            string targetPath1 = @"c:\temp\file2.txt";
//            try
//            {
//                string[] lines = File.ReadAllLines(sourcePath1);
//                using (StreamWriter sw = File.AppendText(targetPath1))
//                {
//                    foreach (string line in lines)
//                    {
//                        sw.WriteLine(line.ToUpper());
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }

//            Console.WriteLine("________________________________**_________________________________");
            
//            try
//            {
//                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
//                Console.WriteLine("FOLDERS:");
//                foreach (string s in folders)
//                {
//                    Console.WriteLine(s);
//                }
//                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
//                Console.WriteLine("FILES:");
//                foreach (string s in files)
//                {
//                    Console.WriteLine(s);
//                }
//                Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error occurred");
//                Console.WriteLine(e.Message);
//            }

//            Console.WriteLine("________________________________**_________________________________");

//            string path1 = @"c:\temp\myfolder\file1.txt";
//            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
//            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
//            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path1));
//            Console.WriteLine("GetFileName: " + Path.GetFileName(path1));
//            Console.WriteLine("GetExtension: " + Path.GetExtension(path1));
//            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path1));
//            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path1));
//            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
//        }
//    }
//}
