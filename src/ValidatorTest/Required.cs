using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidatorEngine.Core.BusinessValidation.DefaultValidations;
using ValidatorEngine.Examples;
using ValidatorEngine.Util;

namespace ValidatorTest
{
	[TestClass]
	public class RequiredTest
	{
		[TestMethod]
		public void RequiredStringTest()
		{
			var requiredString = new RequiredString("myField", null);

			var result = requiredString.Execute();

			Assert.IsTrue(result == false);

			Assert.IsTrue(result.Message == "myField is required");
		}

		[TestMethod]
		public void RequiredNotDefaultStringTest()
		{
			var requiredString = new RequiredString("myField", "", RequiredString.AdditionalConstraint.NotBlankSpace);

			var result = requiredString.Execute();

			Assert.IsTrue(result == false);

			Assert.IsTrue(result.Message == "myField is required");
		}

		[TestMethod]
		public void RequiredPocoNameTest()
		{
			var myPoco = new MyPoco();

			var requiredString = new RequiredString(myPoco.NameOf(m => m.Name), myPoco.Name);

			var result = requiredString.Execute();

			Assert.IsTrue(result == false);

			Assert.IsTrue(result.Message == "Name is required");
		}

		[TestMethod]
		public void RequiredPocoAgeTest()
		{
			var myPoco = new MyPoco();

			var requiredString = new RequiredInt(myPoco.NameOf(m => m.Age), myPoco.Age, RequiredInt.AdditionalConstraint.NotZeroOrDefault);

			var result = requiredString.Execute();

			Assert.IsTrue(result == false);

			Assert.IsTrue(result.Message == "Age is required");
		}
	}
}