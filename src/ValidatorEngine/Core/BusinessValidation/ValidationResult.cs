using System;

namespace ValidatorEngine.Core.BusinessValidation
{
	public class ValidationResult : IEquatable<ValidationResult>
	{
		public Status Status { get; set; }
		public string Message { get; set; }

		public ValidationResult(Status status)
		{
			Status = status;
		}

		public ValidationResult()
			: this(Status.Fail)
		{
		}

		public override string ToString()
		{
			return "Status: " + Status.ToString() + "  -  Message: " + Message;
		}

		public static bool operator ==(ValidationResult validationResult1, ValidationResult validationResult2)
		{
			if (object.ReferenceEquals(validationResult1, null))
			{
				return object.ReferenceEquals(validationResult2, null);
			}

			return validationResult1.Equals(validationResult2);
		}

		public static bool operator !=(ValidationResult validationResult1, ValidationResult validationResult2)
		{
			return !(validationResult1 == validationResult2);
		}

		public static bool operator ==(bool boolValue, ValidationResult validationResult)
		{
			if (validationResult == null)
				return false;

			if (boolValue && validationResult.Status == Status.Sucess ||
				!boolValue && validationResult.Status == Status.Fail)
				return true;

			return false;
		}

		public static bool operator ==(ValidationResult validationResult, bool boolValue)
		{
			return boolValue == validationResult;
		}

		public static bool operator !=(ValidationResult validationResult, bool boolValue)
		{
			return !(boolValue == validationResult);
		}

		public static bool operator !=(bool boolValue, ValidationResult validationResult)
		{
			return !(boolValue == validationResult);
		}

		public static bool operator ==(ValidationResult validationResult, Status statusValue)
		{
			return statusValue == validationResult.Status;
		}

		public static bool operator !=(ValidationResult validationResult, Status statusValue)
		{
			return !(statusValue == validationResult.Status);
		}

		public bool Equals(ValidationResult other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Status == other.Status && string.Equals(Message, other.Message);
		}

		public bool Equals(bool otherBool)
		{
			return this == otherBool;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((ValidationResult)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((int)Status * 397) ^ (Message != null ? Message.GetHashCode() : 0);
			}
		}
	}
}