using System;

namespace RidesUpdater.Models
{
    public class AuthToken
    {
        public String AccessToken { get; set; }
        public String TokenType { get; set; }
        public String Scope { get; set; }
        public int ExpiresIn { get; set; }

        private static AuthToken instance;

        private AuthToken() { }

        public static AuthToken Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthToken();
                }
                return instance;
            }
        }
    }
}
