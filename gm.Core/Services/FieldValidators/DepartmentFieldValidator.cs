namespace gm.Core.Services.FieldValidators
{
    public class DepartmentFieldValidator : IFieldValidator
    {
        public string DepartmentField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            DepartmentField = input.Trim();
            return isValid;
        }
    }
}
