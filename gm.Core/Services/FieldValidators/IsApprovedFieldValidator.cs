using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class IsApprovedFieldValidator : IFieldValidator
    {
        public bool IsApprovedField { get; private set; }

        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid) return isValid;

            IsApprovedField = CommonFieldValidator.ValidateYesNoField(input);
            return isValid;
        }
    }
}
