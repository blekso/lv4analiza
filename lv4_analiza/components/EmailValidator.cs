using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return MeetsAllRequirements(candidate);
        }
        private bool MeetsAllRequirements(string candidate)
        {
            bool hasAt = false, endWithCom = false, endWithHr = false;
            if (candidate.Contains("@")) hasAt = true;
            if (candidate.EndsWith(".com")) endWithCom = true;
            if (candidate.EndsWith(".hr")) endWithHr = true;
            return (hasAt && (endWithCom || endWithHr));
        }
    }
}

