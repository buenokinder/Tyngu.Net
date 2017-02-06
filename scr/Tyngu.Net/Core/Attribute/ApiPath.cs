using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyngu.Net.Core.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiPath : System.Attribute
    {

        public readonly string Path;


        public ApiPath(string path)
        {
            this.Path = path;

        }
    }
}
