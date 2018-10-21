using Autofac;
using Autofac.Extras.DynamicProxy;
using Smart.Auditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DI
{
    public class Program : IProgam
    {
        static void Main(string[] args)
        {


            var b = new ContainerBuilder();
            b.Register(i => new SmartLogger());
            b.RegisterType<Program>().As<IProgam>().EnableInterfaceInterceptors().InterceptedBy(typeof(SmartLogger));
            //b.RegisterType<Program>().EnableClassInterceptors();
            var container = b.Build();




            IProgam p1 = container.BeginLifetimeScope().Resolve<IProgam>();
            p1.DummyInterfaceMethod("Passed in Value");

        }

        public void DummyInterfaceMethod(string value)
        {


                Console.WriteLine("#Logging to the console...." + value);

        }
    }


}
