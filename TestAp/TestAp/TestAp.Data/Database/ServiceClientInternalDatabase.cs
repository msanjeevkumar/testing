using TestAp.Common.DB;
using TestAp.Common.Interfaces;
using TestAp.Data.Entities;
using TestAp.Data.Interfaces;

namespace TestAp.Data.Database
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
