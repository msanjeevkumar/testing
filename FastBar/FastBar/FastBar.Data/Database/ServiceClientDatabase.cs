using System;
using FastBar.Common.DB;
using FastBar.Data.Interfaces;

namespace FastBar.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
