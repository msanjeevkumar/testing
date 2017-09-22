using FastBar.Common.Logging;

namespace FastBar.Common.Interfaces
{
	public interface IApplicationContext
	{
		string CurrentLoggedInUserName { get; set; }

		LogLevel LogLevel { get; set; }
	}
}
