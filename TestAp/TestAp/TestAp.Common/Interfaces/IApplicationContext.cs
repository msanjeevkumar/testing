using TestAp.Common.Logging;

namespace TestAp.Common.Interfaces
{
	public interface IApplicationContext
	{
		string CurrentLoggedInUserName { get; set; }

		LogLevel LogLevel { get; set; }
	}
}
