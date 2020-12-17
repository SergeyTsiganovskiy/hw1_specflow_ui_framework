using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.InterfaceSegregation.Correct
{
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }
}
