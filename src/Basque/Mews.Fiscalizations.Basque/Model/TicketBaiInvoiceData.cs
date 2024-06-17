using System.Xml;

namespace Mews.Fiscalizations.Basque.Model;

public sealed class TicketBaiInvoiceData
{
    public TicketBaiInvoiceData(
        XmlDocument signedRequest,
        string tbaiIdentifier,
        string qrCodeUri,
        String1To100 trimmedSignature)
    {
        SignedRequest = signedRequest;
        TbaiIdentifier = tbaiIdentifier;
        QrCodeUri = qrCodeUri;
        TrimmedSignature = trimmedSignature;
    }

    public XmlDocument SignedRequest { get; }

    public string TbaiIdentifier { get; }

    public string QrCodeUri { get; }

    public String1To100 TrimmedSignature { get; }
}

public sealed class TicketBaiCancelInvoiceData
{
    public TicketBaiCancelInvoiceData(
        XmlDocument signedRequest,
        string trimmedSignature)
    {
        SignedRequest = signedRequest;
        TrimmedSignature = trimmedSignature;
    }

    public XmlDocument SignedRequest { get; }

    //public string TbaiIdentifier { get; }

    //public string QrCodeUri { get; }

    public string TrimmedSignature { get; }
}