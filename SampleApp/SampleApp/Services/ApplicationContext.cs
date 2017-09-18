using SampleApp.Common.Interfaces;
using SampleApp.Common.Logging;

namespace SampleApp.Forms.Services
{
	public class ApplicationContext : IApplicationContext
	{		
		public string CurrentLoggedInUserName { get; set; }

		public LogLevel LogLevel { get; set; }
	}
}
