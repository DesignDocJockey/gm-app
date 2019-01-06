using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class CostRateFieldValidator : IFieldValidator
    {
        public decimal CostRateField { get; private set; }
        public bool IsValid(string input)
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
