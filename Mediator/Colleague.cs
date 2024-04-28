namespace Mediator;
/// <summary>
/// Colleague abstract class
/// </summary>
/// <param name="mediator"></param>
internal abstract class Colleague(IMediator mediator)
{
	protected IMediator mediator = mediator;
}
