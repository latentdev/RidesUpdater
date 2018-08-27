using System;
using System.Collections.Generic;
using System.Text;

namespace RidesUpdater.Models
{
    public class Credentials
    {
        public String AccessTokenURL => "https://authorization.go.com/token";
        public String AccessTokenURLBody => "grant_type=assertion&assertion_type=public&client_id=WDPRO-MOBILE.MDX.WDW.ANDROID-PROD";
        public String AccessTokenURLMethod => "POST";
        public String AppID => "WDW-MDX-ANDROID-3.4.1";
        public String BaseURL => "https://api.wdpro.disney.go.com/";
    }
}
