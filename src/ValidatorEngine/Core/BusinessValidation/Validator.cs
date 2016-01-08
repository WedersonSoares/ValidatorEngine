namespace ValidatorEngine.Core.BusinessValidation
{
	public abstract class Validator
	{
		public ValidationList ValidationList { get; protected set; }

		public ValidationResultList ValidationResultList { get; set; }

		public bool ErrorsAsExceptions { get; set; }

		protected Validator()
		{
			ValidationList = new ValidationList();
		}

		protected Validator(Validation validation)
		{
			AddValidation(validation);
		}

		public void AddValidation(Validation validation)
		{
			ValidationList.Add(validation);
		}

		public void ImportValidations(Validator validator)
		{
		}

		public ValidationResultList Validate()
		{
			var validationResultList = ValidationList.ExecuteValidations();

			return validationResultList;
		}
	}

	//public class OfferCreateValidator: Validator
	//{
	//    public OfferCreateValidator(DTO domain)
	//    {
	//        Validation dateValidation = new DateHihgerThanToday(domain.Date1, domain.Date2, string.Format("Date 1 cannot be lower than today"));

	// AddValidation(dateValidation);

	// }

	// public OfferCreateValidator(Vm vm) { Validation dateValidation = new
	// DateHihgerThanToday(domain.Date1, domain.Date2);

	// AddValidation(dateValidation);

	// }

	//}

	//public class Service
	//{
	//    private Validator GetOfferCreateValidator(dto)
	//    {
	//        OfferCreateSrvValidator offerCreateValidator = new OfferCreateSrvValidator();

	// Validation dateValidation = new DateHihgerThanToday(domain.Date1, domain.Date2);

	// offerCreateValidator.AddValidation(dateValidation);

	// return offerCreateValidator; }

	// public void ExecuteOfferCreate(DTO dto) { var offerCreateValidator = GetOfferCreateValidator(dto);

	// offerCreateValidator.Validate();

	//    }
	//}

	//public class Controller
	//{
	//    public void ExecuteOfferCreate(ViewModel vm)
	//    {
	//        OfferCreateValidator offerCreateValidator = new OfferCreateValidator(vm);

	// offerCreateValidator.Validate();

	//    }
	//}
}