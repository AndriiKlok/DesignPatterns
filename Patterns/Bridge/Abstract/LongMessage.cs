using Patterns.Bridge.Interface;

namespace Patterns.Bridge.Abstract
{
	class LongMessage : AbstractMessage
	{
		public LongMessage(IMessageSender messageSender)
		{
			this.messageSender = messageSender;
		}

		public override void SendMessage(string message)
		{
			messageSender.SendMessage(message);
		}
	}
}
