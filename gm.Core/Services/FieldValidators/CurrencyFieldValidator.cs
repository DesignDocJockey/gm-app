using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class CurrencyFieldValidator : IFieldValidator
    {
        public string CurrencyField { get; private set; }
        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            CurrencyField = input.Trim();
            return isValid;
        }
    }
}
