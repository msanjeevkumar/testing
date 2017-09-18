using Microsoft.Practices.Unity;
using SampleApp.Common.DB;
using SampleApp.Common.Interfaces;
using SampleApp.Common.Logging;
using SampleApp.Common.Providers;
using SampleApp.Data.Database;
using SampleApp.Data.Interfaces;
using SampleApp.Data.Repositories;
using SampleApp.Data.Repositories.Interfaces;

namespace SampleApp.Data
{
	public class DataBootstrapper
	{		
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<ISqLiteConnectionFactory, SqLiteConnectionFactory>(new ContainerControlledLifetimeManager());
			container.RegisterType<ILogsInternalDatabase, LogsInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IAppInternalDatabase, ServiceClientInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IServiceClientInternalDatabase, ServiceClientInternalDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<IServiceClientDatabase, ServiceClientDatabase>(new HierarchicalLifetimeManager());
			container.RegisterType<ILoggingProvider, LogglyLocalDatabaseLoggingProvider>("LogglyLogger",new ContainerControlledLifetimeManager());
			container.RegisterType<ILogger, Logger>();
			container.RegisterType<IConnectivityHelper, ConnectivityHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<ILogsDatabase, LogsDatabase>(new HierarchicalLifetimeManager());

			// Repository Registration goes here.
			container.RegisterType<ITestRepository, TestRepository>(new TransientLifetimeManager());
		}
	}
}
