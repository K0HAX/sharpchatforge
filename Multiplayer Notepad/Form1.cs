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

namespace Sharp.Chatforge
{
    public partial class Form1 : Form
    {
        TcpChannel chan = new TcpChannel();
        chatString superEvent = new chatString();
        RemoteObject obj; //= (RemoteObject)Activator.GetObject(typeof(RemoteObject), "tcp://localhost:1233/NotepadString");
        //private RemoteObject.RemoteObject remObjectClientHandle;

        public Form1()
        {
            InitializeComponent();
            InitializeData(); //for events in the future maybe...
        }

        private void InitializeData()
        {
            ////These don't work yet

            //myEvent.MessageSent += new myEvent.MessageSent();
            //objectHandle.eMessageSent += new myEvent.MessageSent(EventHandler);
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            //Working on making events to remove this stupid timer..

            string myText = "";
            myText = obj.readLog();
            if (myText != uxOutput.Text)
                uxOutput.Text = myText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uxInput.Enabled = false;
            uxName.Enabled = false;
            uxServerIP.Enabled = true;
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

        private void uxServerIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Obsolete code
                //obj = (RemoteObject)Activator.GetObject(typeof(RemoteObject), "tcp://localhost:1233/NotepadString");


                obj = (RemoteObject)Activator.GetObject(typeof(RemoteObject), "tcp://" + uxServerIP.Text + ":1233/NotepadString");
                try
                {
                    if (obj.Equals(null))
                    {
                        MessageBox.Show("Error: Unable to locate server");
                    }
                    else
                    {
                        uxName.Enabled = true;
                        uxServerIP.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Error: object failure");
                    uxServerIP.Enabled = true;
                    uxName.Enabled = false;
                }
                EventListener listener = new EventListener(superEvent);
            }
        }
    }
}
