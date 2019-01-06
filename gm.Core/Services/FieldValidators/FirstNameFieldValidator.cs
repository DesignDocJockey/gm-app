using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class FirstNameFieldValidator : IFieldValidator
    {
        public string FirstNameField { get; private set; }
        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            FirstNameField = input.Trim();
            return isValid;
        }
    }
}
