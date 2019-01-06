using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services.FieldValidators
{
    public class BillableRateFieldValidator : IFieldValidator
    {
        public decimal BillableRateField { get; private set; }
        public bool IsValid(string input)
        {
            var result = Decimal.TryParse(input, out var amount);

            if (amount < 0) result = false;

            if (result)
                BillableRateField = amount;
            else
                BillableRateField = 0;

            return result;
        }
    }
}
