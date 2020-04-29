using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}

