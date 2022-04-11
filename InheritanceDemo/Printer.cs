using System;
namespace InheritanceDemo
{
    public class Printer : Messanger
    {
        
        public string ConnectionString { get; set; }
        public int Port { get; set; }

        public Printer(string connectionString, int port)
        {
            ConnectionString = connectionString;
            Port = port;
        }
    }
}
