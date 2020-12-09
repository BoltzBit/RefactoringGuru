using RefactoringGuru.Creational.AbstractFactory.Interfaces;

namespace RefactoringGuru.Creational.AbstractFactory.ConcreteProduct
{
	public class ConcreteProductB1 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			return "This is a Product B1";
		}
		
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var productA = collaborator.UsefulFunctionA();
			
			return $"Eu estou recebendo esse cara => {productA}";
		}
	}
}