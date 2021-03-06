using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestClass]
	public class ClassWithGenericInterfaceTests
	{
		private IInterface3 subInterface3;
		private IGenericInterface<List<int>> subGenericInterfaceListInt;
		private IGenericInterface<List<ISomeOtherInterface>> subGenericInterfaceListSomeOtherInterface;
		private IGenericInterface<bool> subGenericInterfaceBool;
		private IGenericInterface<List<string>> subGenericInterfaceListString;
		private ISomeInterface subSomeInterface;

		[TestInitialize]
		public void TestInitialize()
		{
			this.subInterface3 = Substitute.For<IInterface3>();
			this.subGenericInterfaceListInt = Substitute.For<IGenericInterface<List<int>>>();
			this.subGenericInterfaceListSomeOtherInterface = Substitute.For<IGenericInterface<List<ISomeOtherInterface>>>();
			this.subGenericInterfaceBool = Substitute.For<IGenericInterface<bool>>();
			this.subGenericInterfaceListString = Substitute.For<IGenericInterface<List<string>>>();
			this.subSomeInterface = Substitute.For<ISomeInterface>();
		}

		private ClassWithGenericInterface CreateClassWithGenericInterface()
		{
			return new ClassWithGenericInterface(
				this.subGenericInterfaceBool,
				this.subGenericInterfaceListString,
				this.subSomeInterface)
			{
				Interface2 = this.subInterface3,
				GenericInterface3 = this.subGenericInterfaceListInt,
				GenericInterface4 = this.subGenericInterfaceListSomeOtherInterface,
			};
		}

		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			var classWithGenericInterface = this.CreateClassWithGenericInterface();

			// Act


			// Assert
			Assert.Fail();
		}
	}
}
