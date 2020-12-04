namespace RefactoringGuru.Creational.Interfaces
{
	public interface IAbstractProductB
	{
		public string UsefulFunctionB();
		
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator);
	}
}
