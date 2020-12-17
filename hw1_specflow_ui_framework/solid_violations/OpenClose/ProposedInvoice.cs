using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.OpenClose
{
    public class ProposedInvoice : BaseInvoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
}
