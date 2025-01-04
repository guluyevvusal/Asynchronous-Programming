using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

//public class Program
//{

    //private static readonly HttpClient client = new HttpClient();

    //public static async Task Main(string[] args)
    //{

    //    await MainAsync();
    //}

    //public static async Task MainAsync()
    //{
    //    string url = "https://jsonplaceholder.typicode.com/posts/1";
    //    string data = await FetchDataAsync(url);
    //    Console.WriteLine(data);
    //}


    //public static async Task<string> FetchDataAsync(string url)
    //{
    //    Console.WriteLine("Data downloading...");
    //    var result = await client.GetStringAsync(url);
    //    Console.WriteLine("Data downloaded.");
    //    return result;
    //}




    // ****************************************************************************************



    //public static void Main(string[] args)
    //{
      
    //    string[] files = { "file1.txt", "file2.txt", "file3.txt", "file4.txt" };

       
    //    ProcessFiles(files);
    //}

  
    //public static void ProcessFiles(string[] files)
    //{
       
    //    Parallel.ForEach(files, file =>
    //    {
    //        Console.WriteLine($"Processing file: {file}");
            
    //        Thread.Sleep(1000); 
    //    });

    //}



    // ****************************************************************************************

//    public class Counter
//    {
//        private int _count = 0;
//        private readonly object _lock = new object();

//        public void Increment()
//        {
//            lock (_lock)
//            {
//                _count++;
//                Console.WriteLine($"Count: {_count}");
//            }
//        }
//    }

//    public static void Main(string[] args)
//    {
//        MainThreadSafety(); 
//    }


//    public static void MainThreadSafety()
//    {
//        Counter counter = new Counter();
//        Parallel.For(0, 10, _ => counter.Increment()); 
//    }

//}




//HttpClient is used to retrieve data from APIs. For example, in an e-commerce system, data is retrieved asynchronously from an API for product information.


//For example, it is used to compress large image files into different folders at the same time.



// For example, in a banking system, if several transactions change a customer's balance at the same time, a lock is used so that the balance is not calculated incorrectly.