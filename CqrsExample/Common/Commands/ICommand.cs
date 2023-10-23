namespace CqrsExample.Common.Commands
{
	public interface ICommand<in TParam, TResult>
	{
		Task<TResult> ExecuteAsync(TParam param);

		TResult Execute(TParam param);
	}
}
