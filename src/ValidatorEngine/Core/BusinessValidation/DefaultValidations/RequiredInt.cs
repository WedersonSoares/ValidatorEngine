using System;

namespace ValidatorEngine.Core.BusinessValidation.DefaultValidations
{
	public class RequiredInt : Required<int?>
	{
		[Flags]
		public enum AdditionalConstraint
		{
			None = 0,
			NotZeroOrDefault = 1,
		}

		public AdditionalConstraint AdditionalConstraints { get; set; }

		public RequiredInt(string fieldName, int? fieldValue, AdditionalConstraint additionalContraints = AdditionalConstraint.None)
			: base(fieldName, fieldValue)
		{
			FieldValue = fieldValue;
			AdditionalConstraints = additionalContraints;
		}

		protected override bool ValidationExpression()
		{
			var baseResult = base.ValidationExpression();

			if (AdditionalConstraints == AdditionalConstraint.NotZeroOrDefault)
			{
				return baseResult && FieldValue != 0;
			}

			return baseResult;
		}
	}
}