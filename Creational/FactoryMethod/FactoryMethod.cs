using System;

namespace RefactoringGuru.Creational
{
	public abstract class Creator
	{
		public abstract IProduct FactoryMethod();
		
		public string SomeOperations()
		{
			var product = FactoryMethod();
			var result = $"Creator: The same creator's code has just worked with: {product.Operation()}";
			
			return result;
		}
	}
	
	public interface IProduct
	{
		string Operation();
	}
	
	public class ConcreteCreator1 : Creator
	{
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct1();
		}
	}
	
	public class ConcreteCreator2 : Creator
	{
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct2();
		}
	}
	
	public class ConcreteProduct1 : IProduct
	{
		public string Operation()
		{
			return "{Return of ConcreteProduct1}";
		}
	}
	
	public class ConcreteProduct2 : IProduct
	{
		public string Operation()
		{
			return "{Return of ConcreteProduct2}";
		}
	}
	
	public class Client2
	{
		public void Main()
		{
			Console.WriteLine("App: Launched with the ConcreteCreator1.");
			ClientCode(new ConcreteCreator1());
			
			Console.WriteLine("App: Launched wiht the ConcreteCreator2");
			ClientCode(new ConcreteCreator2());
		}
		
		public void ClientCode(Creator creator)
		{
			Console.WriteLine($"Client: I'm not aware of the cretor's class, but it still works.\n {creator.SomeOperations()}");
		}
	}
}
