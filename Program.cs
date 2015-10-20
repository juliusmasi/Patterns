using System;

namespace Patterns
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Singleton sing = Singleton.Instance;
			sing.Add();

			Singleton sing2 = Singleton.Instance;
			sing2.Add();

			//Factory pattern
			ConcreteFactory factory = new ConcreteFactory();
			factory.Create("Product1");
			factory.Create("Product2");
			Console.ReadKey();

		}
	}
}
