namespace Mediator;

internal class ColleagueB(IMediator mediator) : Colleague(mediator)
{
	public void Send(string message)
	{
		Console.WriteLine("Colleague B sends message: " + message);
		mediator.Notify(this, "MessageB");
	}
	public void Receive(string message)
	{
		Console.WriteLine("Colleague B receives message: " + message);
	}
}