using Patterns.Bridge.Interface;

namespace Patterns.Bridge.Abstract
{
	abstract class AbstractMessage
	{
		protected IMessageSender messageSender;
		public abstract void SendMessage(string message);
	}
}
