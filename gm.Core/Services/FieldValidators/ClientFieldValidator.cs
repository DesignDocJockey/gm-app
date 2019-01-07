namespace gm.Core.Services.FieldValidators
{
    public class ClientFieldValidator : IFieldValidator
    {
        public string ClientField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            ClientField = input.Trim();
            return isValid;
        }
    }
}
