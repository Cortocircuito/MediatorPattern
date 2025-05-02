using System;

namespace MediatorPattern
{
    public class UserAdmin(string name, Mediator mediator) : Colleague(mediator)
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"Un administrador llamado {name} recibe el mensaje: {message}");
        }
    }
}
