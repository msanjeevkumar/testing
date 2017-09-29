using System;
using TestApp.Common.Enums;

namespace TestApp.Common.Interfaces
{	
	public interface INetworkStatusService
	{		
		event EventHandler NetworkStatusChanged;

		NetworkStatus NetworkStatus();
	}
}
