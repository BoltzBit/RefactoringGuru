using RefactoringGuru.Creational.FactoryMethod.Interfaces;

namespace RefactoringGuru.Creational.FactoryMethod.ConcreteProduct
{
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
}
