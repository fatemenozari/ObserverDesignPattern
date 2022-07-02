using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_design_pattern
{
    public class SMS: IParticipant
    {
        private readonly string _name;
        public SMS(string name)
        {
            _name = name;
        }

        public void Update(ICompany company)
        {
            Console.WriteLine($" Im {_name} , I received the message . ");
        }
    }
}
