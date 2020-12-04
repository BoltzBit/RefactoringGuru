using RefactoringGuru.Creational.Interfaces;
using RefactoringGuru.Creational.ConcreteProduct;

namespace RefactoringGuru.Creational.ConcreteFactory
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
