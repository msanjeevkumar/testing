using System;
using SampleApp.Common.DB;
using SampleApp.Data.Interfaces;

namespace SampleApp.Data.Database
{
	public class ServiceClientDatabase : AppDatabase, IServiceClientDatabase
	{
		public ServiceClientDatabase(IServiceClientInternalDatabase database) : base(database)
		{
		}
	}
}
