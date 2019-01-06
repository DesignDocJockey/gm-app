using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class TaskFieldValdidator : IFieldValidator
    {
        public string TaskField { get; private set; }
        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            TaskField = input.Trim();
            return isValid;
        }
    }
}
