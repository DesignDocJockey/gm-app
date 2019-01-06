using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class IsInvoicedFieldValidator : IFieldValidator
    {
        public bool IsInvoiceField { get; private set; }

        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid) return isValid;

            IsInvoiceField = CommonFieldValidator.ValidateYesNoField(input);
            return isValid;
        }
    }
}
