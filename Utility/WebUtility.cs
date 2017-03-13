using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public interface WebUtility : Utility
    {
        String GetCurrentShortDate();

        String GetCurrentLongDate();

        String GetCurrentMonth();

        String GetCurrentYear();

        String ShortDateFromEpoch(long epoch);

        long EpochMillisFromString(String dateString);

        String ToMD5(String code);

        String ToSHA1(String code);

        String ToRSA(String code);
    }
}
