using System;

namespace gm.Core.Services
{
    public class CommonFieldValidator
    {
        public static bool ValidateStringField(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
                return false;
            return true;
        }

        public static bool ValidateYesNoField(string input)
        {
            var isValid = CommonFieldValidator.ValidateStringField(input);
            if (!isValid) return isValid;

            if (input.Trim().ToUpper().Equals("YES"))
                return true;
            else
                return false;
        }

        public static bool ValidateMonetaryAmount(string input, out decimal monetaryValue)
        {
            var result = Decimal.TryParse(input, out var amount);

            if (amount < 0) result = false;

            if (result)
                monetaryValue = amount;
            else
                monetaryValue = 0;

            return result;
        }
    }
}
