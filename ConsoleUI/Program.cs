using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

            foreach (var service in serviceManager.GetAll().Data)
            {
                Console.WriteLine(service.ServiceName);
            }
        }
    }
}
