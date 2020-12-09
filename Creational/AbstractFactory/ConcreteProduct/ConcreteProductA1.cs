using RefactoringGuru.Creational.AbstractFactory.Interfaces;

namespace RefactoringGuru.Creational.AbstractFactory.ConcreteProduct
{
	public class ConcreteProductA1 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			return "This is a Product A1!";
		}
	}
}
