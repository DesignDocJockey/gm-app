namespace gm.Core.Services.FieldValidators
{
    public class TaskFieldValdidator : IFieldValidator
    {
        public string TaskField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            TaskField = input.Trim();
            return isValid;
        }
    }
}
