namespace RefactoringGuru.Creational.AbstractFactory.Interfaces
{
	public interface IAbstractFactory
	{
		public IAbstractProductA CreateProductA();
		public IAbstractProductB CreateProductB();
	}
}
