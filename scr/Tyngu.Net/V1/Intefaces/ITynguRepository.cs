using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyngu.Net.Core;

namespace Tyngu.Net.V1.Intefaces
{
   
     public interface ITynguRepository<T, U>
        where T : ITynguModel
        where U : ITynguModel
    {

        Response Create(T model);
        T Get(string code);
    }
}
