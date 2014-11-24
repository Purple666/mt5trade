﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mt5trade
{
    interface IQuote
    {
        string Instrument { get; }
        double Bid { get; }
        double Ask { get; }
    }
}
