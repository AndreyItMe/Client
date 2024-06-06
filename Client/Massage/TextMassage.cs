using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try1Server.Massage
{
    [Serializable] //для сериализации
    public class TextMassage : Message
    {
        [Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }

        [Newtonsoft.Json.JsonProperty("senderName")] // от кого письмо
        public string SenderName { get; set; }

        [Newtonsoft.Json.JsonProperty("receiverName")] //кому письмо
        public string ReceiverName { get; set; }
        public TextMassage() { }
    }
}
