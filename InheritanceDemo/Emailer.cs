using System;
namespace InheritanceDemo
{
    public class Emailer : Messanger
    {
        public Emailer(string emailadress, string recipient)
        {
            EmailAdress = emailadress;
            Recipient = recipient;

        }
       
        public string EmailAdress { get; set; }
        public string Recipient { get; set; }
    }
}
