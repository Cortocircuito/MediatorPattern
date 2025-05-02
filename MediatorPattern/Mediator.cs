using System.Collections.Generic;

namespace MediatorPattern
{
    public class Mediator : IMediator
    {
        public readonly List<Colleague> Colleagues = new();

        public void Add(Colleague colleague)
        {
            this.Colleagues.Add(colleague);
        }

        public void Send(string message, Colleague colleague)
        {
            foreach(var c in this.Colleagues)
            {
                if(c != colleague)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
