using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{

    [Flags]
    internal enum SecurityLevel
    {
        guest = 0b0001,
        dev = 0b0010,
        secretary = 0b0100,
        DBA = 0b1000,
        Admin = 0b1111
    }
}
