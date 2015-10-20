using System;
using Patterns;

namespace Patterns
{
	/// <summary>
	/// Client uses Factory to create Product.
	/// </summary>
	public abstract class Factory
	{
		public abstract IProduct Create(string productName);
	}


	/// <summary>
	/// Concrete factory.
	/// </summary>
	public class ConcreteFactory: Factory
	{
		public override IProduct Create(string productName)
		{
			IProduct product;
			switch (product)
			{
			case "Product1":
				product = new ConcreteProduct1();
				break;
			case "Product2":
				product = new ConcreteProduct2();
				break;

			default:
				break;
			}
			return product;
		}
	}


	/// <summary>
	/// The Product interface.
	/// </summary>
	public interface IProduct
	{
		
	}

	/// <summary>
	/// The Concrete product.
	/// </summary>
	public class ConcreteProduct1:IProduct
	{
	}


	/// <summary>
	/// Concrete product2.
	/// </summary>
	public class ConcreteProduct2: IProduct
	{
	}


}

