using System;

namespace Patterns
{
	public sealed class Singleton
	{
		private static volatile Singleton _instance;
		private static object Sync = new object();

		int i =10;

		private Singleton()
		{
		}
		public void Add()
		{
			i++;
			Console.WriteLine(i);
			Console.ReadKey();
		}

		public static Singleton Instance
		{
			get
			{
				if (_instance ==null)
				{
					lock (Sync)
					{
						if (_instance==null)
						{
							_instance = new Singleton();
						}
					}
				}
				return _instance;
			}
		}
	}
}

