﻿using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Core.Services
{
    public interface IFieldValidator
    {
        bool IsValid(string input);
    }

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
            if (input.Trim().ToUpper().Equals("YES"))
                return true;
            else
               return false;
        }
    } 
}
