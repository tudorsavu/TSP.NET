using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public delegate string MyDel(string str);
    class EventExpose
    {
        public event MyDel MyEvent;

        public EventExpose()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

    }
}
