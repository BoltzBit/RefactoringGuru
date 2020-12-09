using RefactoringGuru.Creational.AbstractFactory.Interfaces;
using RefactoringGuru.Creational.AbstractFactory.ConcreteProduct;

namespace RefactoringGuru.Creational.AbstractFactory.ConcreteFactory
{
	public class ConcreteFactory1 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA1();
		}
		
		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB1();
		}
	}
}
