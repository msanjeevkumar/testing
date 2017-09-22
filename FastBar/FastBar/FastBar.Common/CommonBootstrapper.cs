using Microsoft.Practices.Unity;
using FastBar.Common.Logging;

namespace FastBar.Common
{
	public class CommonBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<ILoggingProvider, ConsoleLoggingProvider>("ConsoleLogger", new ContainerControlledLifetimeManager());
		}
	}
}
