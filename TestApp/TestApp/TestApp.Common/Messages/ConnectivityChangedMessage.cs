using System;
using TestApp.Common.Interfaces;

namespace TestApp.Common.Messages
{
	public class ConnectivityChangedMessage : IMessage
	{
		public ConnectivityChangedMessage(bool isConnected)
		{
			IsConnected = isConnected;
		}

		public bool IsConnected { get; private set; }
	}
}
