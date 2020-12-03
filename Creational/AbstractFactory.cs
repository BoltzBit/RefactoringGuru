//Estudos sobre refatoração de código - Abstract Factory
using System;
using RefactoringGuru.Creational.Interfaces;
using RefactoringGuru.Creational.ConcreteFactory;

namespace RefactoringGuru.Creational
{
	public class ConcreteProductA1 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			return "The result of the product A1.";
		}
	}
	
	public class ConcreteProductA2 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			return "The result of the product A2.";
		}
	}
	
	public class ConcreteProductB1 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			return "Concrete product of B1.";
		}
		
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();
			
			return result;
		}
	}
	
	public class ConcreteProductB2 : IAbstractProductB
	{
		public string UsefulFunctionB()
		{
			return "The result of concrete product B2";
		}
		
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();
			
			return result;
		}
	}
	
	public class Client
	{
		public void Main()
		{
			Console.WriteLine("Client: Testing client code with the first factory type...");
			ClientMethod(new ConcreteFactory1());
			Console.WriteLine();
			
			
			Console.WriteLine("Client: Testing the same client code with the second factory type...");
			ClientMethod(new ConcreteFactory2());
		}
		
		public void ClientMethod(IAbstractFactory factory)
		{
			var productA = factory.CreateProductA();
			var productB = factory.CreateProductB();
			
			Console.WriteLine(productB.UsefulFunctionB());
			Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
		}
	}
}
