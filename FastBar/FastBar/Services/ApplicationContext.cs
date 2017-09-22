using FastBar.Common.Interfaces;
using FastBar.Common.Logging;

namespace FastBar.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
