using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            GetPrinter printerService = new GetPrinter();
            Printer printer = printerService.ConnectPrinter();

            printer.Content = "Text for printing.";

            GetEmailer emailerservice = new GetEmailer();
            Emailer emailer = emailerservice.ConnectEmailer();

            emailer.Content = "Hi, Bob!";

            

            List<Messanger> services = new List<Messanger>();

            services.Add(emailer);
            services.Add(printer);


            if(services[0] is Emailer)
            {
            string adress = (services[0] as Emailer).EmailAdress;
            Console.WriteLine(adress);

            }

            if(services[0] is Printer)
            {
            string connectionPrinter = (services[0] as Printer).ConnectionString;
            Console.WriteLine(connectionPrinter);

            }
        }
    }
}
