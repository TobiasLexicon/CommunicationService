using System;
namespace InheritanceDemo
{
    public class GetEmailer : IGetEmailer
    {
        public GetEmailer()
        {

        }

        public Emailer ConnectEmailer()
        {
            Emailer emailer = new Emailer("example@zero.com", "Bob Hope");
            return emailer;
        }
    }
}
