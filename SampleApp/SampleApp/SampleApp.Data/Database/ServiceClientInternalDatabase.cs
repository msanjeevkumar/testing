using SampleApp.Common.DB;
using SampleApp.Common.Interfaces;
using SampleApp.Data.Entities;
using SampleApp.Data.Interfaces;

namespace SampleApp.Data.Database
{
    public class ServiceClientInternalDatabase : AppInternalDatabase, IServiceClientInternalDatabase
	{
		public ServiceClientInternalDatabase(ISqLiteConnectionFactory connectionFactory) : base(connectionFactory.GetAppDBConnection())
		{
			// Create tables here, using following Way,
			Connection.CreateTable<TestEntity>();
		}
	}
}
