using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyngu.Net.Core;

namespace Tyngu.Net
{
    public struct ResponseError
    {
        /// <summary>
        /// Mensagem de retorno
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Erros da mensagem, se existirem
        /// </summary>
        public ResponseDetail[] Errors { get; set; }


        public string FullMessage
        {
            get
            {
                var msg = "";
                if (!string.IsNullOrEmpty(Message))
                {
                    msg += Message + (Errors.Length > 0 ? Environment.NewLine : "");
                }

                msg += string.Join(Environment.NewLine, Errors.Select(x => x.Description).ToArray());

                return msg;
            }
        }

    }
}
