using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class StateExtension
    {
        public static string SplitState(this State text)
        {
            if (text.ToString().Length > 8)
            {
                string aux = text.ToString().Substring(3);
                return $"Por {aux.ToLower()}";
            }
            return text.ToString();
        }
    }
}
