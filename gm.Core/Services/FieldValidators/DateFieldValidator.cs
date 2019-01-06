using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class DateFieldValidator : IFieldValidator
    {
        public DateTime DateField { get; private set; }
        public bool IsValid(string input)
        {
            throw new NotImplementedException();
        }
    }
}
