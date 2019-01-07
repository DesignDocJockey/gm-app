namespace gm.Core.Services.FieldValidators
{
    public class CurrencyFieldValidator : IFieldValidator
    {
        public string CurrencyField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            CurrencyField = input.Trim();
            return isValid;
        }
    }
}
