using System;
using System.Threading;
using System.Threading.Tasks;

namespace TempDotNetCoreConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"entering Main() -- thread {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"call Method2Async(thowExceptionFlag: false)");
                var result = Method2Async(thowExceptionFlag: false).GetAwaiter().GetResult();
                Console.WriteLine($"Method2Async(thowExceptionFlag: false) -- wasSuccessful == '{result.Item1}', message == {result.Item2} ");
                Console.WriteLine($"call Method2Async(thowExceptionFlag: true)");
                result = Method2Async(thowExceptionFlag: true).GetAwaiter().GetResult();
                if (result.ex != null) Console.WriteLine($"let's write out the stack trace --> {result.ex.StackTrace}");
                Console.WriteLine($"Method2Async(thowExceptionFlag: true) -- wasSuccessful == '{result.Item1}', message == {result.Item2} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"catching exception in Main() thread {Thread.CurrentThread.ManagedThreadId} message is --> '" + e.Message + "'");
            }
            finally
            {
                Console.WriteLine("program done");
                Console.Read();
            }
        }

        private static async Task<(bool wasSuccessful, string message, Exception ex)> Method2Async(bool thowExceptionFlag)
        {
            var myTask = Task.Run(() =>
            {
                try
                {
                    Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} sleeping");
                    Thread.Sleep(500);
                    if (thowExceptionFlag) throw new Exception($"something went terribly wrong in thread {Thread.CurrentThread.ManagedThreadId}");
                    return (wasSuccessful: true, message: $"successful execution, thread {Thread.CurrentThread.ManagedThreadId}", null);
                }
                catch (Exception e)
                {
                    //throw; // cannot throw from here when in Visual Studio debug mode 
                    return (wasSuccessful: false, message: $"unsuccessful execution, thread {Thread.CurrentThread.ManagedThreadId}, message was '{e.Message}'", e);
                }
            });
            await Task.WhenAll(myTask);
            return myTask.Result;
        }
    }
}