using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.OpenClose
{
    public class BaseInvoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }
}
