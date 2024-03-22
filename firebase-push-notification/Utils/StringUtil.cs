using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firebase_push_notification.Utils
{
    public static class StringUtil
    {
        public static bool isVaildUrl(string url) {
            if (url.Contains("https://"))
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
