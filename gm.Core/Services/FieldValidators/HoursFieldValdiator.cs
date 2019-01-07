using System;

namespace gm.Core.Services.FieldValidators
{
    public class HoursFieldValdiator : IFieldValidator
    {
        public double HoursField { get; private set; }
        public double HoursRounded { get; private set; }

        public bool IsFieldValid(string input)
        {
            var isValid = Double.TryParse(input, out var hrs);
            if (hrs < 0.0D)
                isValid = false;
            else {
                HoursField = hrs;
                HoursRounded = Math.Round(HoursField);
            }
            return isValid;

        }
    }
}
