using System.Text.RegularExpressions;

namespace gm.Core.Services.FieldValidators
{
    public class NameFieldValidator : IFieldValidator
    {
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!Regex.IsMatch(input.Trim(), @"^[a-z A-Z]+$")) {
                isValid = false;
            }
            return isValid;
        }
    }
}
