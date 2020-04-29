using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    //7.zad
    class FormValidator : IRegistrationValidator
    {
        private EmailValidator email;
        private PasswordValidator pw;

        public FormValidator(int minlenght)
        {
            this.email = new EmailValidator();
            this.pw = new PasswordValidator(minlenght);
        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            bool validEmail = false; bool validPassword = false;
            if (email.IsValidAddress(entry.Email)) validEmail = true;
            if (pw.IsValidPassword(entry.Password)) validPassword = true;
            return validEmail && validPassword;
        }
    }
}
