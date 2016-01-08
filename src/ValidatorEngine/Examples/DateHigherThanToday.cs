using System;
using ValidatorEngine.Core.BusinessValidation;

namespace ValidatorEngine.Examples
{
	public class DateHihgerThanToday : Validation
	{
		private DateTime date1;
		private DateTime date2;

		public DateHihgerThanToday(DateTime date1, DateTime date2, string failMessage)
			: base(failMessage)
		{
		}

		protected override bool ValidationExpression()
		{
			return date1 > date2;
		}
	}
}