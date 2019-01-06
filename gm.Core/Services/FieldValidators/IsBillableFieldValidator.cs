using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class IsBillableFieldValidator : IFieldValidator
    {
        public bool IsBillableField { get; private set; }

        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid) return isValid;

            IsBillableField = CommonFieldValidator.ValidateYesNoField(input);
            return isValid;
        }
    }
}
