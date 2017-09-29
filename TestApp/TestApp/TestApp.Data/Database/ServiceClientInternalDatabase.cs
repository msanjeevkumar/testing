using TestApp.Common.DB;
using TestApp.Common.Interfaces;
using TestApp.Data.Entities;
using TestApp.Data.Interfaces;

namespace TestApp.Data.Database
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
