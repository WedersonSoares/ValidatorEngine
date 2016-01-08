using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidatorEngine.Core.BusinessValidation;

namespace ValidatorTest
{
	[TestClass]
	public class ValidationResultTest
	{
		[TestMethod]
		public void EqualsTest()
		{
			CompareToValidationFail();
			CompareToValidationSuccess();
		}

		private static void CompareToValidationSuccess()
		{
			var status1 = new ValidationResult(Status.Sucess);

			var status2 = new ValidationResult(Status.Sucess);

			Assert.IsTrue(status1 == status2);
		}

		private static void CompareToValidationFail()
		{
			var status1 = new ValidationResult(Status.Fail);

			var status2 = new ValidationResult(Status.Fail);

			Assert.IsTrue(status1 == status2);
		}

		[TestMethod]
		public void EqualsStatusTest()
		{
			CompareToFail();
			CompareToSuccess();
		}

		private static void CompareToSuccess()
		{
			var status1 = new ValidationResult(Status.Sucess);

			var status2 = Status.Sucess;

			Assert.IsTrue(status1 == status2);
		}

		private static void CompareToFail()
		{
			var status1 = new ValidationResult();

			var status2 = new ValidationResult(Status.Fail);

			Assert.IsTrue(status1 == status2);
		}

		[TestMethod]
		public void EqualsBoolTest()
		{
			CompareToFalse();

			CompareToTrue();
		}

		private static void CompareToTrue()
		{
			var status1 = new ValidationResult(Status.Sucess);

			var status2 = true;

			Assert.IsTrue(status1 == status2);
		}

		private static void CompareToFalse()
		{
			var status1 = new ValidationResult();

			var status2 = false;

			Assert.IsTrue(status1 == status2);
		}
	}
}