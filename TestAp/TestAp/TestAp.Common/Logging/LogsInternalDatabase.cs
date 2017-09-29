using System;
using TestAp.Common.DB;
using TestAp.Common.Entities;
using TestAp.Common.Interfaces;

namespace TestAp.Common.Logging
{
	public class LogsInternalDatabase : AppInternalDatabase, ILogsInternalDatabase
	{
		public LogsInternalDatabase(ISqLiteConnectionFactory connectionFactory) : base(connectionFactory.GetLogsConnection())
		{
			// Create tables if they don't exist.
			Connection.CreateTable<LogEntry>();

			Connection.CreateIndex<LogEntry>(x => x.SentToServerAtUtc);
		}
	}
}
