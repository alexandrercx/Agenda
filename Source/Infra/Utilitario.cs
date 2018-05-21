using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belagricola.Infra
{
    public class Utilitario
    {

        public bool ValidaEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, ("(?<user>[^@]+)@(?<host>.+)"));
        }
    }
}
