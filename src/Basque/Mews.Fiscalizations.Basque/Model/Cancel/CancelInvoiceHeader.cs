using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mews.Fiscalizations.Basque.Model
{
    
    public sealed class CancelInvoiceID
    {
        public CancelInvoiceID(Issuer issuer,
          CancelInvoiceHeader header)
        {
            Issuer = issuer;
            Header = header;
        }

        public Issuer Issuer { get; }

        public CancelInvoiceHeader Header { get; }
    }
    public sealed class CancelInvoiceHeader
    {
        public CancelInvoiceHeader(
            string number,
            DateTime issued,
            string series = null)
        {
            Number = number;
            Issued = issued;
            Series = series;
        }


        public string Number { get; }

        public DateTime Issued { get; }

        public string Series { get; }

       
    }
}
