using System;
using RefactoringGuru.Creational.FactoryMethod.Interfaces;

namespace RefactoringGuru.Creational.FactoryMethod.Maker
{
	public abstract class Creator
	{
		public abstract IProduct FactoryMethod();
		
		public string SomeOperations()
		{
			var product = FactoryMethod();
			var result = $"Creator: The same creator's code has just worked with: {product.Operation()}";
			
			return result;
		}
	}
}
