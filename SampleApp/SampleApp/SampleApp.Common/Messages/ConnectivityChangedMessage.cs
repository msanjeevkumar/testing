using System;
using SampleApp.Common.Interfaces;

namespace SampleApp.Common.Messages
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
