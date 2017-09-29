using TestAp.Common.Interfaces;
using TestAp.Common.Logging;

namespace TestAp.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
