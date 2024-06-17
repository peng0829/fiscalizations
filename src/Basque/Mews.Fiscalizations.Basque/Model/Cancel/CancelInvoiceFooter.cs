using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mews.Fiscalizations.Basque.Model
{

    public sealed class CancelInvoiceFooter
    {
        public CancelInvoiceFooter(Software software,  string deviceSerialNumber = null)
        {
            Software = software;
            DeviceSerialNumber = deviceSerialNumber;
        }

        public Software Software { get; }

      
        public string DeviceSerialNumber { get; }
    }
}
