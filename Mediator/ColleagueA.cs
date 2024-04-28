namespace Mediator;

internal class ColleagueA(IMediator mediator) : Colleague(mediator)
{
	public void Send(string message)
	{
		Console.WriteLine("Colleague A sends message: " + message);
		mediator.Notify(this, "MessageA");
	}
	public void Receive(string message)
	{
		Console.WriteLine("Colleague A receives message: " + message);
	}
}
