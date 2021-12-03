using System;
using System.Collections.Generic;
using System.Text;

namespace net_5
{
    interface Paper
    {
        int Format { get; set; }
        void roll_up();
        void cut();
    }
}
