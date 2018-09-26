using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Reader reader = new Reader("File1.txt");
            Reader reader2 =new Reader("File2.txt");
            
            Task readFile1 = new Task(reader.Read);
            Task readFile2 = new Task(reader2.Read);
            
            readFile1.Start();
            readFile2.Start();
            
            while (!readFile1.IsCompleted||!readFile2.IsCompleted)
            {
                Thread.Sleep(1000);
            }
            
            Thread t1 = new Thread(() => CompareFiles(reader,reader2));
            t1.Start();  
        }

        private static void CompareFiles(Reader reader1, Reader reader2)
        {
            if ((reader1.Data).Equals(reader2.Data))
            {
                Console.WriteLine("The files are the same!");    
            }
            else
            {
                Console.WriteLine("The files are different!");
            }
        }
        
    }
}