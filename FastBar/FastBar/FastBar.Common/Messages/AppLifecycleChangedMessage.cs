using System;
using FastBar.Common.Enums;
using FastBar.Common.Interfaces;

namespace FastBar.Common.Messages
{
	public class AppLifecycleChangedMessage : IMessage
	{
        public AppLifecycleChangedMessage(AppLifecycleState lifecyleState)
		{
			CurrentLifecyleState = lifecyleState;
		}

        public AppLifecycleState CurrentLifecyleState { get; set; }
	}
}
