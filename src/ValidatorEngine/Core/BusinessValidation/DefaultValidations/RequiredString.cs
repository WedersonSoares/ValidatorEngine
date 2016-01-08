using System;

namespace ValidatorEngine.Core.BusinessValidation.DefaultValidations
{
	public class RequiredString : Required<string>
	{
		[Flags]
		public enum AdditionalConstraint
		{
			None = 0,
			NotDefault = 1,
			NotEmpty = 2,
			NotBlankSpace = 4
		}

		public AdditionalConstraint AdditionalConstraints { get; set; }

		public RequiredString(string fieldName, string fieldValue, AdditionalConstraint additionalContraints = AdditionalConstraint.None)
			: base(fieldName, fieldValue)
		{
			FieldValue = fieldValue;
			AdditionalConstraints = additionalContraints;
		}

		protected override bool ValidationExpression()
		{
			var baseResult = base.ValidationExpression();

			if (AdditionalConstraints == AdditionalConstraint.NotBlankSpace)
			{
				return baseResult && !string.IsNullOrWhiteSpace(FieldValue);
			}

			return baseResult;
		}
	}
}