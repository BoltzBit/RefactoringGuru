namespace RefactoringGuru.Creational.Interfaces
{
	public interface IAbstractProductB
	{
		string UsefulFunctionB();
		
		string AnotherUsefulFunctionB(IAbstractProductA collaborator);
	}
}
