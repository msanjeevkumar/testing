using FastBar.Common.Interfaces;
using FastBar.Common.Logging;
using XLabs.Forms.Mvvm;

namespace FastBar.Forms.ViewModels
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
