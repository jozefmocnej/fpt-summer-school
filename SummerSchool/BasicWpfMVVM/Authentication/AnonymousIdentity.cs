﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.Authentication
{
    class AnonymousIdentity : CustomIdentity
    {
        public AnonymousIdentity() : base(string.Empty, string.Empty, new string[] { })
        {
        }
    }
}
