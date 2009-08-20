using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Xcelor8.Chat
{
    public partial class Form1 : Form
    {
        TcpChannel chan = new TcpChannel();
        chatString superEvent = new chatString();
        RemoteObject obj = (RemoteObject)Activator.GetObject(typeof(RemoteObject), "tcp://localhost:1233/NotepadString");
        //private RemoteObject.RemoteObject remObjectClientHandle;

        public Form1()
        {
            InitializeComponent();
            // Use the object
            if( obj.Equals(null) )      
            {
                System.Console.WriteLine("Error: unable to locate server");      
            }
            //superEvent.Changed += new myEventChanged(bigString_Changed);
            EventListener listener = new EventListener(superEvent);
            EventListener l = new EventListener(superEvent);
        }

        private void InitializeData()
        {
            //myEvent.MessageSent += new myEvent.MessageSent();
            //objectHandle.eMessageSent += new myEvent.MessageSent(EventHandler);
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            string myText = "";
            myText = obj.readLog();
            if (myText != uxOutput.Text)
                uxOutput.Text = myText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uxInput.Enabled = false;
            timerRefresh.Enabled = false;
        }

        private void uxSendButton_Click(object sender, EventArgs e)
        {
            RemoteObject myObject = new RemoteObject();
            //uxOutput.Text = obj.sendMessage(uxName.Text, uxInput.Text);
            uxOutput.Text = myObject.sendMessage(uxName.Text, uxInput.Text);
            uxInput.Text = "";
        }

        private void uxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                uxOutput.Text = obj.sendMessage(uxName.Text, uxInput.Text);
                uxInput.Text = "";
                // The Enter key was pressed
            }
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            uxOutput.Text = obj.clearChat(uxName.Text);
        }

        private void uxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (uxName.Text != "")
                {
                    uxName.Enabled = false;
                    uxInput.Enabled = true;
                    timerRefresh.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please enter a name for yourself");
                }
            }
        }
    }
}
