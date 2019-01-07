namespace gm.Core.Services.FieldValidators
{
    public class LastNameFieldValidator : IFieldValidator
    {
        public string LastNameField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            LastNameField = input.Trim();
            return isValid;
        }
    }
}
