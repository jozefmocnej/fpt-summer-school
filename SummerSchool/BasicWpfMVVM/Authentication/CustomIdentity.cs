using System;
using System.Security.Principal;

namespace BasicWpfMVVM.Authentication
{
    class CustomIdentity : IIdentity
    {
        public CustomIdentity(string name, string email, string[] roles)
        {

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }

        #region IIdentity Members
        public string AuthenticationType { get { return "Custom authentication"; } }

        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
        #endregion

    }
}
