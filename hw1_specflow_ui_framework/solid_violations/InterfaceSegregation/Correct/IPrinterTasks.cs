﻿using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.InterfaceSegregation.Correct
{
    interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
}
