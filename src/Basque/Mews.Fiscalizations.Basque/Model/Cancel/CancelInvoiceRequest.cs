using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mews.Fiscalizations.Basque.Model
{

    public sealed class CancelInvoiceRequest
    {
        private CancelInvoiceRequest(CancelInvoiceID id, CancelInvoiceFooter invoiceFooter)
        {
            // Subject = subject;
            InvoiceID = id;
            InvoiceFooter = invoiceFooter;
        }

       public CancelInvoiceID InvoiceID { get; }
        public CancelInvoiceFooter InvoiceFooter { get; }

        public static CancelInvoiceRequest CreateRequest(Issuer issuer,
            CancelInvoiceFooter invoiceFooter,
             string number,
            DateTime issued,
            string series = null)
        {
            return new CancelInvoiceRequest(
                new CancelInvoiceID(issuer,new CancelInvoiceHeader(number, issued, series)),
                invoiceFooter);
        }

      

        
    }
}
