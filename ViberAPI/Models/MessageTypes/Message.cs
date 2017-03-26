﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViberAPI.Models.MessageTypes
{
    public class Message
    {
        public string auth_token { get; set; }
        public string from { get; set; }
        public Sender sender { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Sender
    {
        public string name { get; set; }
        public string avatar { get; set; }
    }
}
