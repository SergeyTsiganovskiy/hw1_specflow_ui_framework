using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.SingleResponsibility
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
}
