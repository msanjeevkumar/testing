using System;
using SQLite.Net;

namespace TestApp.Common.Interfaces
{
	public interface ISqLiteConnectionFactory
	{
		SQLiteConnectionWithLock GetLogsConnection();

		SQLiteConnectionWithLock GetAppDBConnection();
	}
}
