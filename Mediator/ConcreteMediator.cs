namespace Mediator;

internal class ConcreteMediator : IMediator
{
	private ColleagueA? colleagueA;
	private ColleagueB? colleagueB;
	public void SetColleagueA(ColleagueA colleagueA)
	{
		this.colleagueA = colleagueA;
	}
	public void SetColleagueB(ColleagueB colleagueB)
	{
		this.colleagueB = colleagueB;
	}
	public void Notify(object sender, string eventName)
	{
		if (sender == colleagueA && eventName == "MessageA")
		{
			colleagueB?.Receive("MessageA");
		}
		else if (sender == colleagueB && eventName == "MessageB")
		{
			colleagueA?.Receive("MessageB");
		}
	}
}
