using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mews.Fiscalizations.Basque.Model
{
    public sealed class CancelInvoiceResponse
    {
        public CancelInvoiceResponse(
            string xmlRequestContent,
            string xmlResponseContent,
            DateTime received,
            InvoiceState state,
            string description,
            string signatureValue,
            IEnumerable<SendInvoiceValidationResult> validationResults = null)
        {
            XmlRequestContent = xmlRequestContent;
            XmlResponseContent = xmlResponseContent;
            Received = received;
            State = state;
            Description = description;
            SignatureValue = signatureValue;
            ValidationResults = validationResults;
        }

        public string XmlRequestContent { get; }

        public string XmlResponseContent { get; }

        public DateTime Received { get; }

        public InvoiceState State { get; }

        public string Description { get; }

        public string SignatureValue { get; }

        public IEnumerable<SendInvoiceValidationResult> ValidationResults { get; }
    }
}
