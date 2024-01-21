using Patterns.Bridge.Interface;
using System;

namespace Patterns.Bridge
{
	class SmsMessageSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine(message + ": sended by SMS");
		}
	}
}
