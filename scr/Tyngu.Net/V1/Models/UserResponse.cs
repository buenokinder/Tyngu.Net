using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyngu.Net.Core.Attribute;
using Tyngu.Net.V1.Intefaces;

namespace Tyngu.Net.V1.Models
{
    public class User {
        public string id { get; set; }
        public string usename { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string date_of_birth { get; set; }
        public string phone_cell { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string user_language { get; set; }
        public string user_branch { get; set; }
        public string orgchart { get; set; }
        public string custom_fields { get; set; }
        public string created { get; set; }
        public string cpf { get; set; }
        public string lms_login_url { get; set; }
    }
     [ApiPath("/users")]
    public class UserResponse : ITynguModel
    {

         public User user { get; set; }
    }
}
