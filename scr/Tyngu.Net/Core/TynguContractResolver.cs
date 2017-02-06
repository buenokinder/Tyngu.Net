using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tyngu.Net.Core
{
    public class TynguContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            var snakeCase = Regex.Replace(propertyName, "([A-Z])", "_$1").ToLower().Trim('_');
            return snakeCase;
        }

    }
}
