using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace Test
{
    public class ValidationResult
    {
        public ValidationResult(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
    }
    public class Validation
    {
        private static readonly Regex EmailAddressPattern = new Regex(@"example-pattern");
        public static Result<ValidationResult> Validate(string emailAddress)
        {
            return Result.Ok()
                .Ensure(EmailAddressIsValid, "Invalid address email")
                .OnSuccess(() => new ValidationResult(true));


            bool EmailAddressIsValid() => EmailAddressPattern.IsMatch(emailAddress);
        }
    }
}
