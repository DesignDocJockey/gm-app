using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class LastNameFieldValidator : IFieldValidator
    {
        public string LastNameField { get; private set; }
        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            LastNameField = input.Trim();
            return isValid;
        }
    }
}
