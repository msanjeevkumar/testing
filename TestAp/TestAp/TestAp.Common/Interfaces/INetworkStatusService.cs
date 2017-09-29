using System;
using TestAp.Common.Enums;

namespace TestAp.Common.Interfaces
{	
	public interface INetworkStatusService
	{		
		event EventHandler NetworkStatusChanged;

		NetworkStatus NetworkStatus();
	}
}
