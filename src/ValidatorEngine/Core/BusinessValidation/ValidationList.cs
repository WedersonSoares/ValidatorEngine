using System.Collections.Generic;

namespace ValidatorEngine.Core.BusinessValidation
{
	public class ValidationList
	{
		public IList<Validation> Validations { get; set; }

        public ValidationList()
        {
            Validations = new List<Validation>();
        }

		public void Add(Validation validation)
		{
			Validations.Add(validation);
		}

		public ValidationResultList ExecuteValidations()
		{
			var validationResultList = new ValidationResultList();

			foreach (var validation in Validations)
			{
				validationResultList.Add(validation.Execute());
			}

			return validationResultList;
		}
	}
}