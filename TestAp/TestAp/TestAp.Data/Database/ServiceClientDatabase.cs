using System;
using TestAp.Common.DB;
using TestAp.Data.Interfaces;

namespace TestAp.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
