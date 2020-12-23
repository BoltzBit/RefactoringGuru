using System;
using RefactoringGuru.Creational.FactoryMethod.Interfaces;
using RefactoringGuru.Creational.FactoryMethod.Maker;
using RefactoringGuru.Creational.FactoryMethod.ConcreteCreator;
using RefactoringGuru.Creational.FactoryMethod.ConcreteProduct;

namespace RefactoringGuru.Creational
{
	public class Client2
	{
		public void Main()
		{
			Console.WriteLine("App: Launched with the ConcreteCreator1.");
			ClientCode(new ConcreteCreator1());
			
			Console.WriteLine("App: Launched wiht the ConcreteCreator2");
			ClientCode(new ConcreteCreator2());
		}
		
		public void ClientCode(Creator creator)
		{
			Console.WriteLine($"Client: I'm not aware of the cretor's class, but it still works.\n {creator.SomeOperations()}");
		}
	}
}
