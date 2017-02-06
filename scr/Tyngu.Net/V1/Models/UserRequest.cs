using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyngu.Net.Core.Attribute;
using Tyngu.Net.V1.Intefaces;

namespace Tyngu.Net.V1
{
    [ApiPath("/users")]
    public class UserRequest : ITynguModel
    {
        public string email { get; set; }
        public string passwd { get; set; }
        public string coupon_code { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string cpf { get; set; }

    }
}
