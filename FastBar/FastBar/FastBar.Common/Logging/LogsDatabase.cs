using System;
using FastBar.Common.Interfaces;
using FastBar.Common.DB;

namespace FastBar.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
