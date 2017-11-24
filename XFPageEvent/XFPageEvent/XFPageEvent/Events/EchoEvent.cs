using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFPageEvent.Events
{

    public class EchoEvent : PubSubEvent<EchoPayload>
    {

    }

    public class EchoPayload
    {
        public string Message { get; set; }
    }


}
