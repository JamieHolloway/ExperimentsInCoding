using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var task2 = Task.Run(() => { throw new MyExceptionClass("something failed"); });

            while (!task2.IsCompleted) { }

            if (task2.Status == TaskStatus.Faulted)
            {
                foreach (var e in task2.Exception.InnerExceptions)
                {
                    if (e is MyExceptionClass)
                    {
                        Console.WriteLine(e.Message);
                    }
                    else
                    {
                        throw e;
                    }
                }
            }


            //

            var task1 = Task.Run(() => throw new MyExceptionClass("something failed"));

            try
            {
                task1.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                {
                    if (e is MyExceptionClass)
                    {
                        Console.WriteLine(e.Message);
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            ///

            try
            {
                Console.WriteLine($"entering Main() -- thread {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine("invoke Method1");
                //Method1().Wait();
                //Console.WriteLine($"from Main() -- thread {Thread.CurrentThread.ManagedThreadId} --> " + Method1().GetAwaiter().GetResult());
                var result = Method2Async().GetAwaiter().GetResult();
                Console.WriteLine($"direct call to Method2Async() returns --> {result} ");
            }
            catch (AggregateException ae)
            {
                Console.WriteLine($"catching AggregatedException in Main() -- thread {Thread.CurrentThread.ManagedThreadId} message is --> " + ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"catching exception in Main() -- thread {Thread.CurrentThread.ManagedThreadId} message is --> " + e.Message);
            }
            finally
            {
                Console.Read();
            }
        }

        //private static async Task<string> Method1()
        //{
        //    try
        //    {
        //        //throw new Exception($"exception tossed before await from Method1(), thread { Thread.CurrentThread.ManagedThreadId}"); // in main's thread
        //        Console.WriteLine($"calling Method@Async from Method1(), thread {Thread.CurrentThread.ManagedThreadId}");
        //        var result = await Method2Async();
        //        //throw new Exception($"exception tossed after await from Method1(), thread { Thread.CurrentThread.ManagedThreadId}");
        //        Console.WriteLine($"result received after Method2Async call was '{result}' in thread {Thread.CurrentThread.ManagedThreadId}"); // not in main's thread
        //        return result + " this is the return from Method1()";
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Method1 exception tossed = {e.Message}");
        //        throw;
        //    }
        //}

        private static async Task<string> Method2Async()
        {
            //try
            //{
            //throw new Exception($"exception tossed before Task.Run() from Method2Async(), thread {Thread.CurrentThread.ManagedThreadId}"); // in Main()'s thread
            var myTask1 = Task.Run(() =>
            {
                //try
                //{
                //throw new Exception($"exception tossed after Task.Run() from Method2Async(), thread {Thread.CurrentThread.ManagedThreadId}"); // not in main's thread
                Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} sleeping");
                Thread.Sleep(2000);
                Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} waking");
                return "result from MyTask1 in Method2Async()";
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine($"exception tossed in Task.Run() block, thread {Thread.CurrentThread.ManagedThreadId}");
                //    throw new AggregateException($"throw new exception from Method@Async, thread {Thread.CurrentThread.ManagedThreadId}"); // can't throw from here?
                //    //return "result from exception catch in MyTask1 in Method2Async()";
                //}
            });
            await Task.WhenAll(myTask1);
            return myTask1.Result;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Method2Async exception tossed from thread {Thread.CurrentThread.ManagedThreadId}, message --> {e.Message}");
            //        throw;
            //    }
        }

        public class MyExceptionClass : Exception
        {
            public MyExceptionClass(String message) : base(message)
            { }
        }
    }
}
