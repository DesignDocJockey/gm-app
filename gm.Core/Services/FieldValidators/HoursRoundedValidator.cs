using System;

namespace gm.Core.Services.FieldValidators
{
    public class HoursRoundedValidator : IFieldValidator
    {
        public decimal HoursRounded { get; private set; } 
        public bool IsFieldValid(string input)
        {
            throw new NotImplementedException();
        }
    }
}
