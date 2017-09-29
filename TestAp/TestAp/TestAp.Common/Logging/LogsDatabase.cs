using System;
using TestAp.Common.Interfaces;
using TestAp.Common.DB;

namespace TestAp.Common.Logging
{
	public class LogsDatabase : AppDatabase, ILogsDatabase
	{
		public LogsDatabase(ILogsInternalDatabase database) : base(database)
		{
		}
	}
}
