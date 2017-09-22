using FastBar.Common.DB;
using FastBar.Common.Interfaces;
using FastBar.Data.Entities;
using FastBar.Data.Interfaces;

namespace FastBar.Data.Database
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
