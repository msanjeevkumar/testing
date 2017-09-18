using SampleApp.Common.Interfaces;
using SampleApp.Common.Logging;
using XLabs.Forms.Mvvm;

namespace SampleApp.Forms.ViewModels
{
	public class BaseViewModel : ViewModel
	{
		protected readonly INavigationService NavigationService;
		protected readonly ILogger Logger;

		public BaseViewModel(INavigationService navigationService, ILogger logger)
		{
			NavigationService = navigationService;
			Logger = logger;
		}
	}
}
