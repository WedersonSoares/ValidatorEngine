namespace ValidatorEngine.Core.BusinessValidation
{
	public interface IValidation
	{
		ValidationResult ValidationResult { get; }
		bool Executed { get; }
		string SuccessMessage { get; }
		string FailMessage { get; }

		ValidationResult Execute();
	}
}