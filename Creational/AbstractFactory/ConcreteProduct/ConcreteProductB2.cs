using RefactoringGuru.Creational.AbstractFactory.Interfaces;

namespace RefactoringGuru.Creational.AbstractFactory.ConcreteProduct
{
	public class ConcreteProductB2 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			return "This is a Product B2";
		}
		
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var productA = collaborator.UsefulFunctionA();
			
			return $"Eu estou recebendo esse cara => {productA}";
		}
	}
}
