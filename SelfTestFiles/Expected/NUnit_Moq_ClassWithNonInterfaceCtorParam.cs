using Moq;
using NUnit.Framework;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestFixture]
	public class ClassWithNonInterfaceCtorParamTests
	{
		private MockRepository mockRepository;

		private Mock<SomeClass> mockSomeClass;

		[SetUp]
		public void SetUp()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);

			this.mockSomeClass = this.mockRepository.Create<SomeClass>();
		}

		private ClassWithNonInterfaceCtorParam CreateClassWithNonInterfaceCtorParam()
		{
			return new ClassWithNonInterfaceCtorParam(
				this.mockSomeClass.Object);
		}

		[Test]
		public void TestMethod1()
		{
			// Arrange
			var classWithNonInterfaceCtorParam = this.CreateClassWithNonInterfaceCtorParam();

			// Act


			// Assert
			Assert.Fail();
			this.mockRepository.VerifyAll();
		}
	}
}
