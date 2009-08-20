using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharp.Chatforge
{
    public class chatString : MarshalByRefObject
    {
        private string myString;
        public delegate void myEventChanged(object sender, EventArgs e);

        public event myEventChanged Changed;

        public chatString()
        {

        }

        public string superString
        {
            get
            {
                return myString;
            }
            set
            {
                OnChanged(EventArgs.Empty);
                myString = value;
            }
        }

        public static implicit operator chatString(string myBuilder)
        {
            chatString s = new chatString();
            s = myBuilder;
            return s;
        }

        public override string ToString()
        {
            return myString; // return the internal string
        }

        public static explicit operator string (chatString x)
        {
            return x.myString;
        }
        
        protected virtual void OnChanged(EventArgs e)
        {
            //Changed.Invoke(this, EventArgs.Empty);
            if (Changed != null)
                Changed(this, e);
        }
    }
}
