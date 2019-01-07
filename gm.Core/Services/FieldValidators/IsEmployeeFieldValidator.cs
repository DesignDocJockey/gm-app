namespace gm.Core.Services.FieldValidators
{
    public class IsEmployeeFieldValidator: IFieldValidator
    { 
        public bool IsEmployeeField { get; private set; }

        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid) return isValid;

            IsEmployeeField = CommonFieldValidator.ValidateYesNoField(input);
            return isValid;
        }
        
    }
}
