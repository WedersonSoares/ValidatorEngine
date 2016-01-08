namespace ValidatorEngine.Core.BusinessValidation
{
	public abstract class Validation : IValidation
	{
		public ValidationResult ValidationResult { get; protected set; }

		public bool Executed { get; protected set; }
		public string SuccessMessage { get; set; }
		public string FailMessage { get; set; }

		protected Validation(string successMessage, string failMessage)
		{
			SuccessMessage = successMessage;
			FailMessage = failMessage;
		}

		protected Validation(string failMessage)
			: this(null, failMessage)
		{
		}

		protected Validation()
		{
		}

		public ValidationResult Execute()
		{
			bool isValid = ValidationExpression();

			var validationResult = new ValidationResult()
			{
				Message = isValid ? SuccessMessage : FailMessage,
				Status = isValid ? Status.Sucess : Status.Fail,
			};

			Executed = true;

			return validationResult;
		}

		protected abstract bool ValidationExpression();
	}
}