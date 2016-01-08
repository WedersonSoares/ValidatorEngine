using ValidatorEngine.Core.BusinessValidation.DefaultValidations;

namespace ValidatorEngine.Examples
{
	public class RequiredNotEmptyOrDefault<T> : Required<T>
	{
		public RequiredNotEmptyOrDefault(string fieldName, T fieldValue)
			: base(fieldName, fieldValue)
		{
			FieldValue = fieldValue;
		}

		protected override bool ValidationExpression()
		{
			if (base.ValidationExpression() && !IsDefault())
			{
				return true;
			}
			return false;
		}

		private bool IsDefault()
		{
			if (typeof(T).Equals(typeof(string)))
			{
				return FieldValue.Equals("");
			}

			return FieldValue.Equals(default(T));
		}
	}
}