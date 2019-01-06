using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class ProjectCodeFieldValidator : IFieldValidator
    {
        public string ProjectCode { get; private set; }

        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            ProjectCode = input.Trim();
            return isValid;
        }
    }
}
