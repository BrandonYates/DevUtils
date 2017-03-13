using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class PublicWebUtilityImpl : WebUtility
    {
        public String Type()
        {
            UtilType type = UtilType.PUBLIC | UtilType.WEB | UtilType.UNSECURE;
            return type.ToString();
        }

        public String Version()
        {
            return "1.0.0";
        }

        public String ReleaseDate()
        {
            return "03/11/2017";
        }

        public String Author()
        {
            return "Brandon Yates";
        }

        public String GetCurrentShortDate()
        {
            return new DateTime().ToShortDateString();
        }

        public String GetCurrentLongDate()
        {
            return new DateTime().ToLongDateString();
        }

        public String GetCurrentMonth()
        {
            return new DateTime().Month.ToString();
        }

        public String GetCurrentYear()
        {
            return new DateTime().Year.ToString();
        }

        public String ShortDateFromEpoch(long timestamp)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            epoch.AddMilliseconds(timestamp);
            return epoch.ToShortDateString();
        }

        public long EpochMillisFromString(String dateString)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var dateTime = DateTime.Parse(dateString).ToUniversalTime();

            return (long)dateTime.Subtract(epoch).TotalMilliseconds;
        }

        public String ToMD5(String code)
        {
            return "Secure operations are not supported by this platform.";
        }

        public String ToSHA1(String code)
        {
            return "Secure operations are not supported by this platform.";
        }

        public String ToRSA(String code)
        {
            return "Secure operations are not supported by this platform.";
        }
    }
}
