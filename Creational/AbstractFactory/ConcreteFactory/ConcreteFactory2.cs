using RefactoringGuru.Creational.AbstractFactory.Interfaces;
using RefactoringGuru.Creational.AbstractFactory.ConcreteProduct;

namespace RefactoringGuru.Creational.AbstractFactory.ConcreteFactory
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
