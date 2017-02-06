using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyngu.Net.Core
{
    public struct Response
    {
        /// <summary>
        /// Mensagem de retorno
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Alertas da mensagem, se existirem
        /// </summary>
        public ResponseDetail[] Alerts { get; set; }

    }
}
