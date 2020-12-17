using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.InterfaceSegregation.Correct
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks,
                                     IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }

        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
}
