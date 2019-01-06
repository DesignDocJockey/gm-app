using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class ClientFieldValidator : IFieldValidator
    {
        public string ClientField { get; private set; }
        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            ClientField = input.Trim();
            return isValid;
        }
    }
}
