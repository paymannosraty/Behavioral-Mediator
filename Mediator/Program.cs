namespace Mediator;

internal class Program
{
	static void Main(string[] args)
	{
		// Create mediator and colleagues
		ConcreteMediator mediator = new ConcreteMediator();
		var colleagueA = new ColleagueA(mediator);
		var colleagueB = new ColleagueB(mediator);

		// Set colleagues on mediator
		mediator.SetColleagueA(colleagueA);
		mediator.SetColleagueB(colleagueB);

		// Send messages between colleagues
		colleagueA.Send("Hello from Colleague A");
		colleagueB.Send("Hi from Colleague B");
	}
}
