using System;
namespace InheritanceDemo
{
    public class GetPrinter : IGetPrinter
    {
        public GetPrinter()
        {
        }

        public Printer ConnectPrinter()
        {
            Printer printer = new Printer("//hp/3056/", 4046);

            return printer;
        }
    }
}
