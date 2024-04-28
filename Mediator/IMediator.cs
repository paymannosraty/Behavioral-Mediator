namespace Mediator;
/// <summary>
/// Mediator interface
/// </summary>
internal interface IMediator
{
	void Notify(object sender, string eventName);
}
