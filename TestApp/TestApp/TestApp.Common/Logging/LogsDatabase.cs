using System;
using TestApp.Common.Interfaces;
using TestApp.Common.DB;

namespace TestApp.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
