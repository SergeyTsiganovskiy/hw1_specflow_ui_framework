using System;

namespace solid_violations.OpenClose
{
    class Client
    {
        static void Main(string[] args)
        {
            BaseInvoice FInvoice = new FinalInvoice();
            BaseInvoice PInvoice = new ProposedInvoice();
            BaseInvoice RInvoice = new RecurringInvoice();

            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

            Console.ReadKey();
        }
    }
}
