using System;
using TestApp.Common.DB;
using TestApp.Data.Interfaces;

namespace TestApp.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
