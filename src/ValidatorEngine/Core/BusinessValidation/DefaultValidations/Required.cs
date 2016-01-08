namespace ValidatorEngine.Core.BusinessValidation.DefaultValidations
{
	public class Required<T> : Validation
	{
		public T FieldValue { get; set; }

		private const string baseMessage = "{0} is required";

		protected Required(string fieldName, T fieldValue)
			: base(FormatMessage(fieldName))
		{
			FieldValue = fieldValue;
		}

		private static string FormatMessage(string fieldName)
		{
			return string.Format(baseMessage, fieldName);
		}

		protected override bool ValidationExpression()
		{
			if (IsNull())
				return false;

			return true;
		}

		protected bool IsNull()
		{
			return FieldValue == null;
		}

		protected bool IsDefault()
		{
			return ReferenceEquals(FieldValue, default(T));
		}
	}
}