using System;

namespace gm.Core.Services.FieldValidators
{
    public class CostRateFieldValidator : IFieldValidator
    {
        public decimal CostRateField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var result = Decimal.TryParse(input, out var amount);

            if (amount < 0) result = false;

            if (result)
                CostRateField = amount;
            else
                CostRateField = 0;

            return result;
        }
    }
}
