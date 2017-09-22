using System;
using System.Threading.Tasks;
using FastBar.Common.Enums;

namespace FastBar.Common.Interfaces
{
	public interface IConnectivityHelper
	{
		bool IsConnected { get; }

		NetworkStatus NetworkStatus { get; }

		Task InitiateCheckingAsync();

		void ContinueChecking();

		void PauseChecking();

		Task SetConnectionAsync();
	}
}
