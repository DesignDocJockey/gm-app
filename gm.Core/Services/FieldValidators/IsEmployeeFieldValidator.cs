using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class IsEmployeeFieldValidator: IFieldValidator
    { 
        public bool IsEmployeeField { get; private set; }

        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid) return isValid;

            IsEmployeeField = CommonFieldValidator.ValidateYesNoField(input);
            return isValid;
        }
        
    }
}
