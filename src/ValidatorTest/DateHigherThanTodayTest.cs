using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidatorEngine.Examples;

namespace ValidatorTest
{
	[TestClass]
	public class ValidationTest
	{
		[TestMethod]
		public void DateHigherThanTodayTest()
		{
			var date1 = new DateTime(2015, 10, 11);
			var date2 = new DateTime(2015, 10, 12);

			string sucessMessage = "Date should be higher than today";

			var dateHigherThanTodayTest = new DateHihgerThanToday(date1, date2, sucessMessage);

			var result = dateHigherThanTodayTest.Execute();

			Assert.IsTrue(result == false);

			Assert.IsTrue(result.Message == sucessMessage);
		}
	}
}