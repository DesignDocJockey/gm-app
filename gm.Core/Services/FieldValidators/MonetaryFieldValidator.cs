using System;

namespace gm.Core.Services.FieldValidators
{
    public class BillableRateFieldValidator : IFieldValidator
    {
        public decimal BillableRateField { get; private set; }
        public bool IsFieldValid(string input)
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
