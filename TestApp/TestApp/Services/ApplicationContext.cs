using TestApp.Common.Interfaces;
using TestApp.Common.Logging;

namespace TestApp.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
