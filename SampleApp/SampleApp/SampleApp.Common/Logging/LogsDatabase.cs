using System;
using SampleApp.Common.Interfaces;
using SampleApp.Common.DB;

namespace SampleApp.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
