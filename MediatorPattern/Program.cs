namespace MediatorPattern
{
    class Program
    {
        private static void Main()
        {
            var mediator = new Mediator();

            Colleague oPepe = new User(mediator);
            Colleague oAdmin = new UserAdmin("Juan", mediator);
            Colleague oAdmin2 = new UserAdmin("Miguel", mediator);

            mediator.Add(oPepe);
            mediator.Add(oAdmin);
            mediator.Add(oAdmin2);

            oPepe.Comunicate("Oye admin tengo un problema");

        }
    }
}
