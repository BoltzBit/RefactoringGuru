using RefactoringGuru.Creational.FactoryMethod.Maker;
using RefactoringGuru.Creational.FactoryMethod.Interfaces;
using RefactoringGuru.Creational.FactoryMethod.ConcreteProduct;

namespace RefactoringGuru.Creational.FactoryMethod.ConcreteCreator
{
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
}
