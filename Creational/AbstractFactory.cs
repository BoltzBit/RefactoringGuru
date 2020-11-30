//Estudos sobre refatoração de código - Abstract Factory
using System;

namespace RefactoringGuru.Creational
{
	interface IAbstractFactory
	{
		IAbstractFactoryA CreateProductA();
		IAbstractFactoryB CreateProductB();
	}
	
	public class ConcreteFactory1 : IAbstractFactory
	{
		public IAbstractFactoryA CreateProductA()
		{
			return new ConcreteProductA1();
		}
		
		public IAbstractFactoryB CreateProductB()
		{
			return new ConcreteProductB1();
		}
	}
}
