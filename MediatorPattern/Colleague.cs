namespace MediatorPattern
{
    public abstract class Colleague
    {
        private readonly IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Comunicate(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }
}
