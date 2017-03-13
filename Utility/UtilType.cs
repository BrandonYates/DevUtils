using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    [Flags]
    public enum UtilType
    {
        //0000 0000
        CONSOLE = 0x00,
        //0000 0001
        WEB = 0x01,
        //0000 0010
        PUBLIC = 0x02,
        //0000 0100
        PRIVATE = 0x04,
        //0000 1000
        SECURE = 0x08,
        //0001 0000
        UNSECURE = 0x16,
        //0010 0000
        THREADED,
    }
}
