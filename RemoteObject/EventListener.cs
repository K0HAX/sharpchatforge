using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xcelor8.Chat
{
    public class EventListener
    {
        chatString superEvent = new chatString();
        public EventListener(chatString superEvent)
        {
            superEvent.Changed += new Xcelor8.Chat.chatString.myEventChanged(superEvent_Changed);
        }

        private void superEvent_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Detach()
        {
            // Detach the event and delete the list
            superEvent.Changed -= new Xcelor8.Chat.chatString.myEventChanged(superEvent_Changed);
            superEvent = null;
        }
    }
}
