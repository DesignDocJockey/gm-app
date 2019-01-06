using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class HoursRoundedValidator : IFieldValidator
    {
        public decimal HoursRounded { get; private set; } 
        public bool IsValid(string input)
        {
            throw new NotImplementedException();
        }
    }
}
