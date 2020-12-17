using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.InterfaceSegregation.Violation
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }
}
