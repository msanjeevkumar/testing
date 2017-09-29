using System;
using TestAp.Common.Enums;
using TestAp.Common.Interfaces;

namespace TestAp.Common.Messages
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
