﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Client
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }

        public new void AcceptRejectRule()
        {
            
        }
        public Contact() {}
    }
}
