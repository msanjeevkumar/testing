using System;
using Microsoft.Practices.Unity;
using TestApp.Common.Interfaces;
using TestApp.Forms.iOS.PlatformServices;
using TestApp.Forms.iOS.Utils;
using TestApp.iOS.Helpers;
using TestApp.iOS.Providers;

namespace TestApp.Forms.iOS
{
	public class IosBootstrapper
	{
		public static void Initialize(IUnityContainer container)
		{
			// Interface and Class Registration goes here.
			container.RegisterType<IAppConfig, IosAppConfig>(new TransientLifetimeManager());
			container.RegisterType<INetworkStatusService, IOSNetworkStatusServices>(new HierarchicalLifetimeManager());
			container.RegisterType<IThreadExecutionProvider, ThreadExecutionProvider>(new TransientLifetimeManager());
			container.RegisterType<IStackFrameHelper, StackFrameHelper>(new ContainerControlledLifetimeManager());
			container.RegisterType<IPlatformService, PlatformServiceIos>(new ContainerControlledLifetimeManager());
			container.RegisterType<IGoogleAnalyticsServices, IosGoogleAnalyticsServices>(new ContainerControlledLifetimeManager());
			container.RegisterType<IDialogService, IosDialogService>(new TransientLifetimeManager());
			container.RegisterType<IAppAnalyticsProvider, RaygunAppAnalyticsProvider>(new TransientLifetimeManager());
			container.RegisterType<IFileSystemHelper, FileSystemHelper>(new TransientLifetimeManager());
			container.RegisterType<IEncryptionProvider, EncryptionProvider>(new TransientLifetimeManager());
		}
	}
}
