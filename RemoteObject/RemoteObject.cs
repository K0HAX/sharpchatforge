using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Sharp.Chatforge
{
    public class RemoteObject : MarshalByRefObject
    {
        chatString superEvent = new chatString();
        public RemoteObject()
        {

        }
        
        public delegate void MessageSent(string message);

        //public abstract event MessageSent eMessageSent;

        //private string EpicString = "";

        public string sendMessage(string name, string message)
        {
            
            string oldString = superEvent.superString;
            string makeString = string.Format("{0}:{1}   {2}{3}{4}",
                name,
                Environment.NewLine,
                message,
                Environment.NewLine,
                oldString);

            //myEvent.changeString(makeString);
            superEvent.superString = makeString;
            //eMessageSent(EpicString);
            Console.WriteLine("## New Message ##");
            Console.WriteLine(name + ": " + message);
            Console.WriteLine("## End New Message##");
            return superEvent.superString;
        }

        public string readLog()
        {
            string returnerString = superEvent.superString;
            return returnerString;
        }

        public string clearChat(string name)
        {
            //myEvent.changeString("***" + name + " cleared the chat log***");
            superEvent.superString = "***" + name + " cleared the chat log***";
            Console.WriteLine("!!!Chat Log Erased!!!");
            Console.WriteLine("Erased by: " + name);
            Console.WriteLine("!!!End Chat Log Erased!!!");
            return superEvent.superString;
        }
    }
}
