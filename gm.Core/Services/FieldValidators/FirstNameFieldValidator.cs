namespace gm.Core.Services.FieldValidators
{
    public class FirstNameFieldValidator : IFieldValidator
    {
        public string FirstNameField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            FirstNameField = input.Trim();
            return isValid;
        }
    }
}
