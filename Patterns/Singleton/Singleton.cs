using System;

namespace Patterns
{
	public sealed class Singleton
	{
		private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

		public static Singleton Instance => _instance.Value;
		private Singleton() { }
	}
}
