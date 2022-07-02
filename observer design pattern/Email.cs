using System;

namespace observer_design_pattern
{
    public class Email : IParticipant
    {
        private readonly string _name;
        public Email(string name)
        {
            _name = name;
        }
        public void Update(ICompany company)
        {
            Console.WriteLine($" Im {_name} , I received the message . ");
        }
    }
}
