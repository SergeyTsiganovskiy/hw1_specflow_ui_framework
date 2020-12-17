using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.OpenClose
{
    public class FinalInvoice : BaseInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
}
