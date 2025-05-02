using System;

namespace MediatorPattern
{
    public class User(Mediator mediator) : Colleague(mediator)
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"Un usuario recive el mensaje: {message}");
        }
    }
}
