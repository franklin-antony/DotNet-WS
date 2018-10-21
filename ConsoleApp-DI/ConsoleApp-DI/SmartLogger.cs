using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Auditor
{
    class SmartLogger : IInterceptor
    {

                
         public void Intercept(IInvocation invocation)
            {
                var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
                var args = string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()));

                Console.WriteLine($"Interecepted Calling: {name}");
                Console.WriteLine($"Args: [ {args} ]");
            
                var watch = System.Diagnostics.Stopwatch.StartNew();
                invocation.Proceed(); //Intercepted method is executed here.
                watch.Stop();
                var executionTime = watch.ElapsedMilliseconds;

                Console.WriteLine($"Done: result was [ {invocation.ReturnValue} ]");
                Console.WriteLine($"Execution Time: {executionTime} ms.");
                Console.WriteLine();

            }


    }
}
