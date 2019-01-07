using System;

namespace gm.Core.Services.FieldValidators
{
    public class DateFieldValidator : IFieldValidator
    {
        public DateTime DateField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid)
                return isValid;
            else
            {
                isValid = DateTime.TryParse(input, out var dateField);
                if (isValid)
                    DateField = dateField;
            }

            return isValid;
        }
    }
}
