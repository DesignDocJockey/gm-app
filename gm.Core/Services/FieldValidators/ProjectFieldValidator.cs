using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class ProjectFieldValidator : IFieldValidator
    {
        public string ProjectField { get; private set; }
        public bool IsValid(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            ProjectField = input.Trim();
            return isValid;
        }
    }
}
