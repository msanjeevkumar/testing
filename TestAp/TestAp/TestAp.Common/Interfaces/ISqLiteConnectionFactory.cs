using System;
using SQLite.Net;

namespace TestAp.Common.Interfaces
{
	public interface ISqLiteConnectionFactory
	{
		SQLiteConnectionWithLock GetLogsConnection();

		SQLiteConnectionWithLock GetAppDBConnection();
	}
}
