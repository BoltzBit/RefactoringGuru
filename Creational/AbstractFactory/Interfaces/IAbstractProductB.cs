namespace RefactoringGuru.Creational.AbstractFactory.Interfaces
{
	public interface IAbstractProductB
	{
		public string UsefulFunctionB();
		
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator);
	}
}
