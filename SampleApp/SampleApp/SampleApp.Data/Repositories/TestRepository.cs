using System.Threading.Tasks;
using SampleApp.Common.Logging;
using SampleApp.Data.Entities;
using SampleApp.Data.Interfaces;
using SampleApp.Data.Repositories.Interfaces;

namespace SampleApp.Data.Repositories
{
	public class TestRepository : RepositoryBase, ITestRepository
	{		
		public TestRepository(IServiceClientDatabase database, ILogger logger) : base(database, logger)
		{			
		}

		public async Task DeleteItem(TestEntity testEntity)
		{
			await Database.DeleteAsync<TestEntity>(testEntity);
		}

		public async Task<TestEntity> GetTestEntity(string key)
		{
			return await Database.GetFirstOrDefaultByQueryAsync<TestEntity>(x => x.EntityKey == key);
		}

		public async Task SaveItem(TestEntity testEntity)
		{
			await Database.InsertAsync<TestEntity>(testEntity);
		}

		public async Task UpdateItem(TestEntity testEntity)
		{
			await Database.UpdateAsync<TestEntity>(testEntity);
		}
	}
}
