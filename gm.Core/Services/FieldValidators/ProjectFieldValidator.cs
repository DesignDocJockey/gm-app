namespace gm.Core.Services.FieldValidators
{
    public class ProjectFieldValidator : IFieldValidator
    {
        public string ProjectField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            ProjectField = input.Trim();
            return isValid;
        }
    }
}
