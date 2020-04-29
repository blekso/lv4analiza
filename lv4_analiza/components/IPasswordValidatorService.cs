using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
