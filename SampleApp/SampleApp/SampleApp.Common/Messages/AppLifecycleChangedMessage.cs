using System;
using SampleApp.Common.Enums;
using SampleApp.Common.Interfaces;

namespace SampleApp.Common.Messages
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
