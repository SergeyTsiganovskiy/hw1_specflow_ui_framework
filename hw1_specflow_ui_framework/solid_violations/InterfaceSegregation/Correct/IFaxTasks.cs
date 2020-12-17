using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.InterfaceSegregation.Correct
{
    interface IFaxTasks
    {
        void Fax(string content);
    }
}
