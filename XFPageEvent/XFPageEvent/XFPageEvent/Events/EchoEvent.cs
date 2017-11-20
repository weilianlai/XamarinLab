using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFPageEvent.Events
{

    public class EchoEvent : PubSubEvent<EchoEventPayload>
    {

    }

    public class EchoEventPayload
    {
        public string Message { get; set; }
    }

}
