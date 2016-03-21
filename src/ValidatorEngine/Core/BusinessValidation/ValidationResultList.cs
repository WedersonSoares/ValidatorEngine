using System.Collections.Generic;

namespace ValidatorEngine.Core.BusinessValidation
{
	public class ValidationResultList
	{
		public IList<ValidationResult> ValidationResults { get; set; }
        public ValidationResultList()
        {
            ValidationResults = new List<ValidationResult>();
        }

		public void Add(ValidationResult validationResult)
		{
			ValidationResults.Add(validationResult);
		}

		public bool HasFailures()
		{
			bool hasFailures = false;

			foreach (var validationResult in ValidationResults)
			{
				hasFailures = validationResult.Status == Status.Fail;
			}

			return hasFailures;
		}
	}
}