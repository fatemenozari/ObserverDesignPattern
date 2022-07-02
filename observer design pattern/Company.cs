using System;
using System.Collections.Generic;

namespace observer_design_pattern
{
    public class Company : ICompany
    {

        private readonly List<IParticipant> _participant = new List<IParticipant>();
        public void Attach(IParticipant participant)
        {
            _participant.Add(participant);
        }

        public void Detach(IParticipant observer)
        {
            _participant.Remove(observer);
        }
        public void Notify()
        {
            Console.WriteLine(" Start notifiyng participants... ");

            foreach (var participant in _participant)
            {
                participant.Update(this);
            }
        }

        public void Lottery(string message)
        {
            Console.WriteLine($"\n{message}");
            Notify();
        }
    }

}

