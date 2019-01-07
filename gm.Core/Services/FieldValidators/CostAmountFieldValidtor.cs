using System;

namespace gm.Core.Services.FieldValidators
{
    public class CostAmountFieldValidtor : IFieldValidator
    {
        public decimal CostAmountField { get; private set; }
        public bool IsFieldValid(string input)
        {
            var result = Decimal.TryParse(input, out var amount);

            if (amount < 0) result = false;

            if (result)
                CostAmountField = amount;
            else
                CostAmountField = 0;

            return result;
        }
    }
}
