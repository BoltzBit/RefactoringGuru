using RefactoringGuru.Creational.Interfaces;
using RefactoringGuru.Creational.ConcreteProduct;

namespace RefactoringGuru.Creational.ConcreteFactory
{
	public class ConcreteFactory2 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA2();
		}
		
		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB2();
		}
	}
}
