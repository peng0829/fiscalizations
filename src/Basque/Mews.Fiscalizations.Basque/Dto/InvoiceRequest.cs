﻿namespace Mews.Fiscalizations.Basque.Dto;

using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.CodeDom.Compiler;



/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class Cabecera
{

    private IDVersionTicketBaiType iDVersionTBAIField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IDVersionTicketBaiType IDVersionTBAI
    {
        get
        {
            return iDVersionTBAIField;
        }
        set
        {
            iDVersionTBAIField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public enum IDVersionTicketBaiType
{

    /// <remarks/>
    [XmlEnum("1.2")]
    Item12,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class ObjectType
{

    private System.Xml.XmlNode[] anyField;

    private string idField;

    private string mimeTypeField;

    private string encodingField;

    /// <remarks/>
    [XmlText]
    [XmlAnyElement]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return anyField;
        }
        set
        {
            anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute]
    public string MimeType
    {
        get
        {
            return mimeTypeField;
        }
        set
        {
            mimeTypeField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Encoding
    {
        get
        {
            return encodingField;
        }
        set
        {
            encodingField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SPKIDataType
{

    private byte[][] sPKISexpField;

    private System.Xml.XmlElement anyField;

    /// <remarks/>
    [XmlElement("SPKISexp", DataType = "base64Binary")]
    public byte[][] SPKISexp
    {
        get
        {
            return sPKISexpField;
        }
        set
        {
            sPKISexpField = value;
        }
    }

    /// <remarks/>
    [XmlAnyElement]
    public System.Xml.XmlElement Any
    {
        get
        {
            return anyField;
        }
        set
        {
            anyField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class PGPDataType
{

    private object[] itemsField;

    private ItemsChoiceType1[] itemsElementNameField;

    /// <remarks/>
    [XmlAnyElement]
    [XmlElement("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }

    /// <remarks/>
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType1[] ItemsElementName
    {
        get
        {
            return itemsElementNameField;
        }
        set
        {
            itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType1
{

    /// <remarks/>
    [XmlEnum("##any:")]
    Item,

    /// <remarks/>
    PGPKeyID,

    /// <remarks/>
    PGPKeyPacket,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public class X509IssuerSerialType
{

    private string x509IssuerNameField;

    private string x509SerialNumberField;

    /// <remarks/>
    public string X509IssuerName
    {
        get
        {
            return x509IssuerNameField;
        }
        set
        {
            x509IssuerNameField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "integer")]
    public string X509SerialNumber
    {
        get
        {
            return x509SerialNumberField;
        }
        set
        {
            x509SerialNumberField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class X509DataType
{

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    /// <remarks/>
    [XmlAnyElement]
    [XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType))]
    [XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("X509SubjectName", typeof(string))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }

    /// <remarks/>
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return itemsElementNameField;
        }
        set
        {
            itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType
{

    /// <remarks/>
    [XmlEnum("##any:")]
    Item,

    /// <remarks/>
    X509CRL,

    /// <remarks/>
    X509Certificate,

    /// <remarks/>
    X509IssuerSerial,

    /// <remarks/>
    X509SKI,

    /// <remarks/>
    X509SubjectName,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class RetrievalMethodType
{

    private TransformType[] transformsField;

    private string uRIField;

    private string typeField;

    /// <remarks/>
    [XmlArrayItem("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get
        {
            return transformsField;
        }
        set
        {
            transformsField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get
        {
            return uRIField;
        }
        set
        {
            uRIField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class TransformType
{

    private object[] itemsField;

    private string[] textField;

    private string algorithmField;

    /// <remarks/>
    [XmlAnyElement]
    [XmlElement("XPath", typeof(string))]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }

    /// <remarks/>
    [XmlText]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return algorithmField;
        }
        set
        {
            algorithmField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class RSAKeyValueType
{

    private byte[] modulusField;

    private byte[] exponentField;

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] Modulus
    {
        get
        {
            return modulusField;
        }
        set
        {
            modulusField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] Exponent
    {
        get
        {
            return exponentField;
        }
        set
        {
            exponentField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class DSAKeyValueType
{

    private byte[] pField;

    private byte[] qField;

    private byte[] gField;

    private byte[] yField;

    private byte[] jField;

    private byte[] seedField;

    private byte[] pgenCounterField;

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] P
    {
        get
        {
            return pField;
        }
        set
        {
            pField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] Q
    {
        get
        {
            return qField;
        }
        set
        {
            qField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] G
    {
        get
        {
            return gField;
        }
        set
        {
            gField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] Y
    {
        get
        {
            return yField;
        }
        set
        {
            yField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] J
    {
        get
        {
            return jField;
        }
        set
        {
            jField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] Seed
    {
        get
        {
            return seedField;
        }
        set
        {
            seedField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] PgenCounter
    {
        get
        {
            return pgenCounterField;
        }
        set
        {
            pgenCounterField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class KeyValueType
{

    private object itemField;

    private string[] textField;

    /// <remarks/>
    [XmlAnyElement]
    [XmlElement("DSAKeyValue", typeof(DSAKeyValueType))]
    [XmlElement("RSAKeyValue", typeof(RSAKeyValueType))]
    public object Item
    {
        get
        {
            return itemField;
        }
        set
        {
            itemField = value;
        }
    }

    /// <remarks/>
    [XmlText]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class KeyInfoType
{

    private object[] itemsField;

    private ItemsChoiceType2[] itemsElementNameField;

    private string[] textField;

    private string idField;

    /// <remarks/>
    [XmlAnyElement]
    [XmlElement("KeyName", typeof(string))]
    [XmlElement("KeyValue", typeof(KeyValueType))]
    [XmlElement("MgmtData", typeof(string))]
    [XmlElement("PGPData", typeof(PGPDataType))]
    [XmlElement("RetrievalMethod", typeof(RetrievalMethodType))]
    [XmlElement("SPKIData", typeof(SPKIDataType))]
    [XmlElement("X509Data", typeof(X509DataType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }

    /// <remarks/>
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType2[] ItemsElementName
    {
        get
        {
            return itemsElementNameField;
        }
        set
        {
            itemsElementNameField = value;
        }
    }

    /// <remarks/>
    [XmlText]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType2
{

    /// <remarks/>
    [XmlEnum("##any:")]
    Item,

    /// <remarks/>
    KeyName,

    /// <remarks/>
    KeyValue,

    /// <remarks/>
    MgmtData,

    /// <remarks/>
    PGPData,

    /// <remarks/>
    RetrievalMethod,

    /// <remarks/>
    SPKIData,

    /// <remarks/>
    X509Data,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignatureValueType
{

    private string idField;

    private byte[] valueField;

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    /// <remarks/>
    [XmlText(DataType = "base64Binary")]
    public byte[] Value
    {
        get
        {
            return valueField;
        }
        set
        {
            valueField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class DigestMethodType
{

    private System.Xml.XmlNode[] anyField;

    private string algorithmField;

    /// <remarks/>
    [XmlText]
    [XmlAnyElement]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return anyField;
        }
        set
        {
            anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return algorithmField;
        }
        set
        {
            algorithmField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class ReferenceType
{

    private TransformType[] transformsField;

    private DigestMethodType digestMethodField;

    private byte[] digestValueField;

    private string idField;

    private string uRIField;

    private string typeField;

    /// <remarks/>
    [XmlArrayItem("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get
        {
            return transformsField;
        }
        set
        {
            transformsField = value;
        }
    }

    /// <remarks/>
    public DigestMethodType DigestMethod
    {
        get
        {
            return digestMethodField;
        }
        set
        {
            digestMethodField = value;
        }
    }

    /// <remarks/>
    [XmlElement(DataType = "base64Binary")]
    public byte[] DigestValue
    {
        get
        {
            return digestValueField;
        }
        set
        {
            digestValueField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get
        {
            return uRIField;
        }
        set
        {
            uRIField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Type
    {
        get
        {
            return typeField;
        }
        set
        {
            typeField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignatureMethodType
{

    private string hMACOutputLengthField;

    private System.Xml.XmlNode[] anyField;

    private string algorithmField;

    /// <remarks/>
    [XmlElement(DataType = "integer")]
    public string HMACOutputLength
    {
        get
        {
            return hMACOutputLengthField;
        }
        set
        {
            hMACOutputLengthField = value;
        }
    }

    /// <remarks/>
    [XmlText]
    [XmlAnyElement]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return anyField;
        }
        set
        {
            anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return algorithmField;
        }
        set
        {
            algorithmField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class CanonicalizationMethodType
{

    private System.Xml.XmlNode[] anyField;

    private string algorithmField;

    /// <remarks/>
    [XmlText]
    [XmlAnyElement]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return anyField;
        }
        set
        {
            anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return algorithmField;
        }
        set
        {
            algorithmField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignedInfoType
{

    private CanonicalizationMethodType canonicalizationMethodField;

    private SignatureMethodType signatureMethodField;

    private ReferenceType[] referenceField;

    private string idField;

    /// <remarks/>
    public CanonicalizationMethodType CanonicalizationMethod
    {
        get
        {
            return canonicalizationMethodField;
        }
        set
        {
            canonicalizationMethodField = value;
        }
    }

    /// <remarks/>
    public SignatureMethodType SignatureMethod
    {
        get
        {
            return signatureMethodField;
        }
        set
        {
            signatureMethodField = value;
        }
    }

    /// <remarks/>
    [XmlElement("Reference")]
    public ReferenceType[] Reference
    {
        get
        {
            return referenceField;
        }
        set
        {
            referenceField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignatureType
{

    private SignedInfoType signedInfoField;

    private SignatureValueType signatureValueField;

    private KeyInfoType keyInfoField;

    private ObjectType[] objectField;

    private string idField;

    /// <remarks/>
    public SignedInfoType SignedInfo
    {
        get
        {
            return signedInfoField;
        }
        set
        {
            signedInfoField = value;
        }
    }

    /// <remarks/>
    public SignatureValueType SignatureValue
    {
        get
        {
            return signatureValueField;
        }
        set
        {
            signatureValueField = value;
        }
    }

    /// <remarks/>
    public KeyInfoType KeyInfo
    {
        get
        {
            return keyInfoField;
        }
        set
        {
            keyInfoField = value;
        }
    }

    /// <remarks/>
    [XmlElement("Object")]
    public ObjectType[] Object
    {
        get
        {
            return objectField;
        }
        set
        {
            objectField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class IDOtro
{

    private CountryType2? codigoPaisField;

    private bool codigoPaisFieldSpecified;

    private IDTypeType iDTypeField;

    private string idField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CountryType2? CodigoPais
    {
        get
        {
            return codigoPaisField;
        }
        set
        {
            codigoPaisField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool CodigoPaisSpecified
    {
        get
        {
            return codigoPaisFieldSpecified;
        }
        set
        {
            codigoPaisFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IDTypeType IDType
    {
        get
        {
            return iDTypeField;
        }
        set
        {
            iDTypeField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ID
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public enum CountryType2
{

    /// <remarks/>
    AF,

    /// <remarks/>
    AL,

    /// <remarks/>
    DE,

    /// <remarks/>
    AD,

    /// <remarks/>
    AO,

    /// <remarks/>
    AI,

    /// <remarks/>
    AQ,

    /// <remarks/>
    AG,

    /// <remarks/>
    SA,

    /// <remarks/>
    DZ,

    /// <remarks/>
    AR,

    /// <remarks/>
    AM,

    /// <remarks/>
    AW,

    /// <remarks/>
    AU,

    /// <remarks/>
    AT,

    /// <remarks/>
    AZ,

    /// <remarks/>
    BS,

    /// <remarks/>
    BH,

    /// <remarks/>
    BD,

    /// <remarks/>
    BB,

    /// <remarks/>
    BE,

    /// <remarks/>
    BZ,

    /// <remarks/>
    BJ,

    /// <remarks/>
    BM,

    /// <remarks/>
    BY,

    /// <remarks/>
    BO,

    /// <remarks/>
    BA,

    /// <remarks/>
    BW,

    /// <remarks/>
    BV,

    /// <remarks/>
    BR,

    /// <remarks/>
    BN,

    /// <remarks/>
    BG,

    /// <remarks/>
    BF,

    /// <remarks/>
    BI,

    /// <remarks/>
    BT,

    /// <remarks/>
    CV,

    /// <remarks/>
    KY,

    /// <remarks/>
    KH,

    /// <remarks/>
    CM,

    /// <remarks/>
    CA,

    /// <remarks/>
    CF,

    /// <remarks/>
    CC,

    /// <remarks/>
    CO,

    /// <remarks/>
    KM,

    /// <remarks/>
    CG,

    /// <remarks/>
    CD,

    /// <remarks/>
    CK,

    /// <remarks/>
    KP,

    /// <remarks/>
    KR,

    /// <remarks/>
    CI,

    /// <remarks/>
    CR,

    /// <remarks/>
    HR,

    /// <remarks/>
    CU,

    /// <remarks/>
    TD,

    /// <remarks/>
    CZ,

    /// <remarks/>
    CL,

    /// <remarks/>
    CN,

    /// <remarks/>
    CY,

    /// <remarks/>
    CW,

    /// <remarks/>
    DK,

    /// <remarks/>
    DM,

    /// <remarks/>
    DO,

    /// <remarks/>
    EC,

    /// <remarks/>
    EG,

    /// <remarks/>
    AE,

    /// <remarks/>
    ER,

    /// <remarks/>
    SK,

    /// <remarks/>
    SI,

    /// <remarks/>
    ES,

    /// <remarks/>
    US,

    /// <remarks/>
    EE,

    /// <remarks/>
    ET,

    /// <remarks/>
    FO,

    /// <remarks/>
    PH,

    /// <remarks/>
    FI,

    /// <remarks/>
    FJ,

    /// <remarks/>
    FR,

    /// <remarks/>
    GA,

    /// <remarks/>
    GM,

    /// <remarks/>
    GE,

    /// <remarks/>
    GS,

    /// <remarks/>
    GH,

    /// <remarks/>
    GI,

    /// <remarks/>
    GD,

    /// <remarks/>
    GR,

    /// <remarks/>
    GL,

    /// <remarks/>
    GU,

    /// <remarks/>
    GT,

    /// <remarks/>
    GG,

    /// <remarks/>
    GN,

    /// <remarks/>
    GQ,

    /// <remarks/>
    GW,

    /// <remarks/>
    GY,

    /// <remarks/>
    HT,

    /// <remarks/>
    HM,

    /// <remarks/>
    HN,

    /// <remarks/>
    HK,

    /// <remarks/>
    HU,

    /// <remarks/>
    IN,

    /// <remarks/>
    ID,

    /// <remarks/>
    IR,

    /// <remarks/>
    IQ,

    /// <remarks/>
    IE,

    /// <remarks/>
    IM,

    /// <remarks/>
    IS,

    /// <remarks/>
    IL,

    /// <remarks/>
    IT,

    /// <remarks/>
    JM,

    /// <remarks/>
    JP,

    /// <remarks/>
    JE,

    /// <remarks/>
    JO,

    /// <remarks/>
    KZ,

    /// <remarks/>
    KE,

    /// <remarks/>
    KG,

    /// <remarks/>
    KI,

    /// <remarks/>
    KW,

    /// <remarks/>
    LA,

    /// <remarks/>
    LS,

    /// <remarks/>
    LV,

    /// <remarks/>
    LB,

    /// <remarks/>
    LR,

    /// <remarks/>
    LY,

    /// <remarks/>
    LI,

    /// <remarks/>
    LT,

    /// <remarks/>
    LU,

    /// <remarks/>
    XG,

    /// <remarks/>
    MO,

    /// <remarks/>
    MK,

    /// <remarks/>
    MG,

    /// <remarks/>
    MY,

    /// <remarks/>
    MW,

    /// <remarks/>
    MV,

    /// <remarks/>
    ML,

    /// <remarks/>
    MT,

    /// <remarks/>
    FK,

    /// <remarks/>
    MP,

    /// <remarks/>
    MA,

    /// <remarks/>
    MH,

    /// <remarks/>
    MU,

    /// <remarks/>
    MR,

    /// <remarks/>
    YT,

    /// <remarks/>
    UM,

    /// <remarks/>
    MX,

    /// <remarks/>
    FM,

    /// <remarks/>
    MD,

    /// <remarks/>
    MC,

    /// <remarks/>
    MN,

    /// <remarks/>
    ME,

    /// <remarks/>
    MS,

    /// <remarks/>
    MZ,

    /// <remarks/>
    MM,

    /// <remarks/>
    NA,

    /// <remarks/>
    NR,

    /// <remarks/>
    CX,

    /// <remarks/>
    NP,

    /// <remarks/>
    NI,

    /// <remarks/>
    NE,

    /// <remarks/>
    NG,

    /// <remarks/>
    NU,

    /// <remarks/>
    NF,

    /// <remarks/>
    NO,

    /// <remarks/>
    NC,

    /// <remarks/>
    NZ,

    /// <remarks/>
    IO,

    /// <remarks/>
    OM,

    /// <remarks/>
    NL,

    /// <remarks/>
    BQ,

    /// <remarks/>
    PK,

    /// <remarks/>
    PW,

    /// <remarks/>
    PA,

    /// <remarks/>
    PG,

    /// <remarks/>
    PY,

    /// <remarks/>
    PE,

    /// <remarks/>
    PN,

    /// <remarks/>
    PF,

    /// <remarks/>
    PL,

    /// <remarks/>
    PT,

    /// <remarks/>
    PR,

    /// <remarks/>
    QA,

    /// <remarks/>
    GB,

    /// <remarks/>
    RW,

    /// <remarks/>
    RO,

    /// <remarks/>
    RU,

    /// <remarks/>
    SB,

    /// <remarks/>
    SV,

    /// <remarks/>
    WS,

    /// <remarks/>
    AS,

    /// <remarks/>
    KN,

    /// <remarks/>
    SM,

    /// <remarks/>
    SX,

    /// <remarks/>
    PM,

    /// <remarks/>
    VC,

    /// <remarks/>
    SH,

    /// <remarks/>
    LC,

    /// <remarks/>
    ST,

    /// <remarks/>
    SN,

    /// <remarks/>
    RS,

    /// <remarks/>
    SC,

    /// <remarks/>
    SL,

    /// <remarks/>
    SG,

    /// <remarks/>
    SY,

    /// <remarks/>
    SO,

    /// <remarks/>
    LK,

    /// <remarks/>
    SZ,

    /// <remarks/>
    ZA,

    /// <remarks/>
    SD,

    /// <remarks/>
    SS,

    /// <remarks/>
    SE,

    /// <remarks/>
    CH,

    /// <remarks/>
    SR,

    /// <remarks/>
    TH,

    /// <remarks/>
    TW,

    /// <remarks/>
    TZ,

    /// <remarks/>
    TJ,

    /// <remarks/>
    PS,

    /// <remarks/>
    TF,

    /// <remarks/>
    TL,

    /// <remarks/>
    TG,

    /// <remarks/>
    TK,

    /// <remarks/>
    TO,

    /// <remarks/>
    TT,

    /// <remarks/>
    TN,

    /// <remarks/>
    TC,

    /// <remarks/>
    TM,

    /// <remarks/>
    TR,

    /// <remarks/>
    TV,

    /// <remarks/>
    UA,

    /// <remarks/>
    UG,

    /// <remarks/>
    UY,

    /// <remarks/>
    UZ,

    /// <remarks/>
    VU,

    /// <remarks/>
    VA,

    /// <remarks/>
    VE,

    /// <remarks/>
    VN,

    /// <remarks/>
    VG,

    /// <remarks/>
    VI,

    /// <remarks/>
    WF,

    /// <remarks/>
    YE,

    /// <remarks/>
    DJ,

    /// <remarks/>
    ZM,

    /// <remarks/>
    ZW,

    /// <remarks/>
    QU,

    /// <remarks/>
    XB,

    /// <remarks/>
    XU,

    /// <remarks/>
    XN,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public enum IDTypeType
{

    /// <remarks/>
    [XmlEnum("02")]
    Item02,

    /// <remarks/>
    [XmlEnum("03")]
    Item03,

    /// <remarks/>
    [XmlEnum("04")]
    Item04,

    /// <remarks/>
    [XmlEnum("05")]
    Item05,

    /// <remarks/>
    [XmlEnum("06")]
    Item06,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class EntidadDesarrolladoraType
{

    private object itemField;

    /// <remarks/>
    [XmlElement("IDOtro", typeof(IDOtro), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlElement("NIF", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object Item
    {
        get
        {
            return itemField;
        }
        set
        {
            itemField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class SoftwareFacturacionType
{

    private string licenciaTBAIField;

    private EntidadDesarrolladoraType entidadDesarrolladoraField;

    private string nombreField;

    private string versionField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LicenciaTBAI
    {
        get
        {
            return licenciaTBAIField;
        }
        set
        {
            licenciaTBAIField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public EntidadDesarrolladoraType EntidadDesarrolladora
    {
        get
        {
            return entidadDesarrolladoraField;
        }
        set
        {
            entidadDesarrolladoraField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Nombre
    {
        get
        {
            return nombreField;
        }
        set
        {
            nombreField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class HuellaTBAI
{

    private SoftwareFacturacionType softwareField;

    private string numSerieDispositivoField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SoftwareFacturacionType Software
    {
        get
        {
            return softwareField;
        }
        set
        {
            softwareField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumSerieDispositivo
    {
        get
        {
            return numSerieDispositivoField;
        }
        set
        {
            numSerieDispositivoField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class CabeceraFacturaType
{

    private string serieFacturaField;

    private string numFacturaField;

    private string fechaExpedicionFacturaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SerieFactura
    {
        get
        {
            return serieFacturaField;
        }
        set
        {
            serieFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumFactura
    {
        get
        {
            return numFacturaField;
        }
        set
        {
            numFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaExpedicionFactura
    {
        get
        {
            return fechaExpedicionFacturaField;
        }
        set
        {
            fechaExpedicionFacturaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class Emisor
{

    private string nIFField;

    private string apellidosNombreRazonSocialField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NIF
    {
        get
        {
            return nIFField;
        }
        set
        {
            nIFField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ApellidosNombreRazonSocial
    {
        get
        {
            return apellidosNombreRazonSocialField;
        }
        set
        {
            apellidosNombreRazonSocialField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:anulacion")]
public class IDFactura
{

    private Emisor emisorField;

    private CabeceraFacturaType cabeceraFacturaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Emisor Emisor
    {
        get
        {
            return emisorField;
        }
        set
        {
            emisorField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CabeceraFacturaType CabeceraFactura
    {
        get
        {
            return cabeceraFacturaField;
        }
        set
        {
            cabeceraFacturaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class TransformsType
{

    private TransformType[] transformField;

    /// <remarks/>
    [XmlElement("Transform")]
    public TransformType[] Transform
    {
        get
        {
            return transformField;
        }
        set
        {
            transformField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class ManifestType
{

    private ReferenceType[] referenceField;

    private string idField;

    /// <remarks/>
    [XmlElement("Reference")]
    public ReferenceType[] Reference
    {
        get
        {
            return referenceField;
        }
        set
        {
            referenceField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignaturePropertiesType
{

    private SignaturePropertyType[] signaturePropertyField;

    private string idField;

    /// <remarks/>
    [XmlElement("SignatureProperty")]
    public SignaturePropertyType[] SignatureProperty
    {
        get
        {
            return signaturePropertyField;
        }
        set
        {
            signaturePropertyField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignaturePropertyType
{

    private System.Xml.XmlElement[] itemsField;

    private string[] textField;

    private string targetField;

    private string idField;

    /// <remarks/>
    [XmlAnyElement]
    public System.Xml.XmlElement[] Items
    {
        get
        {
            return itemsField;
        }
        set
        {
            itemsField = value;
        }
    }

    /// <remarks/>
    [XmlText]
    public string[] Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "anyURI")]
    public string Target
    {
        get
        {
            return targetField;
        }
        set
        {
            targetField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:ticketbai:emision")]
[XmlRoot(Namespace = "urn:ticketbai:emision", IsNullable = false)]
public class TicketBai
{

    private Cabecera1 cabeceraField;

    private Sujetos sujetosField;

    private Factura facturaField;

    private HuellaTBAI1 huellaTBAIField;

    private SignatureType signatureField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Cabecera1 Cabecera
    {
        get
        {
            return cabeceraField;
        }
        set
        {
            cabeceraField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Sujetos Sujetos
    {
        get
        {
            return sujetosField;
        }
        set
        {
            sujetosField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Factura Factura
    {
        get
        {
            return facturaField;
        }
        set
        {
            facturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public HuellaTBAI1 HuellaTBAI
    {
        get
        {
            return huellaTBAIField;
        }
        set
        {
            huellaTBAIField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public SignatureType Signature
    {
        get
        {
            return signatureField;
        }
        set
        {
            signatureField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "Cabecera", Namespace = "urn:ticketbai:emision")]
public class Cabecera1
{

    private IDVersionTicketBaiType1 iDVersionTBAIField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IDVersionTicketBaiType1 IDVersionTBAI
    {
        get
        {
            return iDVersionTBAIField;
        }
        set
        {
            iDVersionTBAIField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(TypeName = "IDVersionTicketBaiType", Namespace = "urn:ticketbai:emision")]
public enum IDVersionTicketBaiType1
{

    /// <remarks/>
    [XmlEnum("1.2")]
    Item12,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class Sujetos
{

    private Emisor1 emisorField;

    private IDDestinatario[] destinatariosField;

    private SiNoType variosDestinatariosField;

    private bool variosDestinatariosFieldSpecified;

    private EmitidaPorTercerosType? emitidaPorTercerosODestinatarioField;

    private bool emitidaPorTercerosODestinatarioFieldSpecified;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Emisor1 Emisor
    {
        get
        {
            return emisorField;
        }
        set
        {
            emisorField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public IDDestinatario[] Destinatarios
    {
        get
        {
            return destinatariosField;
        }
        set
        {
            destinatariosField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SiNoType VariosDestinatarios
    {
        get
        {
            return variosDestinatariosField;
        }
        set
        {
            variosDestinatariosField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool VariosDestinatariosSpecified
    {
        get
        {
            return variosDestinatariosFieldSpecified;
        }
        set
        {
            variosDestinatariosFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public EmitidaPorTercerosType? EmitidaPorTercerosODestinatario
    {
        get
        {
            return emitidaPorTercerosODestinatarioField;
        }
        set
        {
            emitidaPorTercerosODestinatarioField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool EmitidaPorTercerosODestinatarioSpecified
    {
        get
        {
            return emitidaPorTercerosODestinatarioFieldSpecified;
        }
        set
        {
            emitidaPorTercerosODestinatarioFieldSpecified = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "Emisor", Namespace = "urn:ticketbai:emision")]
public class Emisor1
{

    private string nIFField;

    private string apellidosNombreRazonSocialField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NIF
    {
        get
        {
            return nIFField;
        }
        set
        {
            nIFField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ApellidosNombreRazonSocial
    {
        get
        {
            return apellidosNombreRazonSocialField;
        }
        set
        {
            apellidosNombreRazonSocialField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class IDDestinatario
{

    private object itemField;

    private string apellidosNombreRazonSocialField;

    private string codigoPostalField;

    private string direccionField;

    /// <remarks/>
    [XmlElement("IDOtro", typeof(IDOtro1), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlElement("NIF", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object Item
    {
        get
        {
            return itemField;
        }
        set
        {
            itemField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ApellidosNombreRazonSocial
    {
        get
        {
            return apellidosNombreRazonSocialField;
        }
        set
        {
            apellidosNombreRazonSocialField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CodigoPostal
    {
        get
        {
            return codigoPostalField;
        }
        set
        {
            codigoPostalField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Direccion
    {
        get
        {
            return direccionField;
        }
        set
        {
            direccionField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "IDOtro", Namespace = "urn:ticketbai:emision")]
public class IDOtro1
{

    private CountryType21? codigoPaisField;

    private bool codigoPaisFieldSpecified;

    private IDTypeType1 iDTypeField;

    private string idField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CountryType21? CodigoPais
    {
        get
        {
            return codigoPaisField;
        }
        set
        {
            codigoPaisField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool CodigoPaisSpecified
    {
        get
        {
            return codigoPaisFieldSpecified;
        }
        set
        {
            codigoPaisFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IDTypeType1 IDType
    {
        get
        {
            return iDTypeField;
        }
        set
        {
            iDTypeField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ID
    {
        get
        {
            return idField;
        }
        set
        {
            idField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(TypeName = "CountryType2", Namespace = "urn:ticketbai:emision")]
public enum CountryType21
{

    /// <remarks/>
    AF,

    /// <remarks/>
    AL,

    /// <remarks/>
    DE,

    /// <remarks/>
    AD,

    /// <remarks/>
    AO,

    /// <remarks/>
    AI,

    /// <remarks/>
    AQ,

    /// <remarks/>
    AG,

    /// <remarks/>
    SA,

    /// <remarks/>
    DZ,

    /// <remarks/>
    AR,

    /// <remarks/>
    AM,

    /// <remarks/>
    AW,

    /// <remarks/>
    AU,

    /// <remarks/>
    AT,

    /// <remarks/>
    AZ,

    /// <remarks/>
    BS,

    /// <remarks/>
    BH,

    /// <remarks/>
    BD,

    /// <remarks/>
    BB,

    /// <remarks/>
    BE,

    /// <remarks/>
    BZ,

    /// <remarks/>
    BJ,

    /// <remarks/>
    BM,

    /// <remarks/>
    BY,

    /// <remarks/>
    BO,

    /// <remarks/>
    BA,

    /// <remarks/>
    BW,

    /// <remarks/>
    BV,

    /// <remarks/>
    BR,

    /// <remarks/>
    BN,

    /// <remarks/>
    BG,

    /// <remarks/>
    BF,

    /// <remarks/>
    BI,

    /// <remarks/>
    BT,

    /// <remarks/>
    CV,

    /// <remarks/>
    KY,

    /// <remarks/>
    KH,

    /// <remarks/>
    CM,

    /// <remarks/>
    CA,

    /// <remarks/>
    CF,

    /// <remarks/>
    CC,

    /// <remarks/>
    CO,

    /// <remarks/>
    KM,

    /// <remarks/>
    CG,

    /// <remarks/>
    CD,

    /// <remarks/>
    CK,

    /// <remarks/>
    KP,

    /// <remarks/>
    KR,

    /// <remarks/>
    CI,

    /// <remarks/>
    CR,

    /// <remarks/>
    HR,

    /// <remarks/>
    CU,

    /// <remarks/>
    TD,

    /// <remarks/>
    CZ,

    /// <remarks/>
    CL,

    /// <remarks/>
    CN,

    /// <remarks/>
    CY,

    /// <remarks/>
    CW,

    /// <remarks/>
    DK,

    /// <remarks/>
    DM,

    /// <remarks/>
    DO,

    /// <remarks/>
    EC,

    /// <remarks/>
    EG,

    /// <remarks/>
    AE,

    /// <remarks/>
    ER,

    /// <remarks/>
    SK,

    /// <remarks/>
    SI,

    /// <remarks/>
    ES,

    /// <remarks/>
    US,

    /// <remarks/>
    EE,

    /// <remarks/>
    ET,

    /// <remarks/>
    FO,

    /// <remarks/>
    PH,

    /// <remarks/>
    FI,

    /// <remarks/>
    FJ,

    /// <remarks/>
    FR,

    /// <remarks/>
    GA,

    /// <remarks/>
    GM,

    /// <remarks/>
    GE,

    /// <remarks/>
    GS,

    /// <remarks/>
    GH,

    /// <remarks/>
    GI,

    /// <remarks/>
    GD,

    /// <remarks/>
    GR,

    /// <remarks/>
    GL,

    /// <remarks/>
    GU,

    /// <remarks/>
    GT,

    /// <remarks/>
    GG,

    /// <remarks/>
    GN,

    /// <remarks/>
    GQ,

    /// <remarks/>
    GW,

    /// <remarks/>
    GY,

    /// <remarks/>
    HT,

    /// <remarks/>
    HM,

    /// <remarks/>
    HN,

    /// <remarks/>
    HK,

    /// <remarks/>
    HU,

    /// <remarks/>
    IN,

    /// <remarks/>
    ID,

    /// <remarks/>
    IR,

    /// <remarks/>
    IQ,

    /// <remarks/>
    IE,

    /// <remarks/>
    IM,

    /// <remarks/>
    IS,

    /// <remarks/>
    IL,

    /// <remarks/>
    IT,

    /// <remarks/>
    JM,

    /// <remarks/>
    JP,

    /// <remarks/>
    JE,

    /// <remarks/>
    JO,

    /// <remarks/>
    KZ,

    /// <remarks/>
    KE,

    /// <remarks/>
    KG,

    /// <remarks/>
    KI,

    /// <remarks/>
    KW,

    /// <remarks/>
    LA,

    /// <remarks/>
    LS,

    /// <remarks/>
    LV,

    /// <remarks/>
    LB,

    /// <remarks/>
    LR,

    /// <remarks/>
    LY,

    /// <remarks/>
    LI,

    /// <remarks/>
    LT,

    /// <remarks/>
    LU,

    /// <remarks/>
    XG,

    /// <remarks/>
    MO,

    /// <remarks/>
    MK,

    /// <remarks/>
    MG,

    /// <remarks/>
    MY,

    /// <remarks/>
    MW,

    /// <remarks/>
    MV,

    /// <remarks/>
    ML,

    /// <remarks/>
    MT,

    /// <remarks/>
    FK,

    /// <remarks/>
    MP,

    /// <remarks/>
    MA,

    /// <remarks/>
    MH,

    /// <remarks/>
    MU,

    /// <remarks/>
    MR,

    /// <remarks/>
    YT,

    /// <remarks/>
    UM,

    /// <remarks/>
    MX,

    /// <remarks/>
    FM,

    /// <remarks/>
    MD,

    /// <remarks/>
    MC,

    /// <remarks/>
    MN,

    /// <remarks/>
    ME,

    /// <remarks/>
    MS,

    /// <remarks/>
    MZ,

    /// <remarks/>
    MM,

    /// <remarks/>
    NA,

    /// <remarks/>
    NR,

    /// <remarks/>
    CX,

    /// <remarks/>
    NP,

    /// <remarks/>
    NI,

    /// <remarks/>
    NE,

    /// <remarks/>
    NG,

    /// <remarks/>
    NU,

    /// <remarks/>
    NF,

    /// <remarks/>
    NO,

    /// <remarks/>
    NC,

    /// <remarks/>
    NZ,

    /// <remarks/>
    IO,

    /// <remarks/>
    OM,

    /// <remarks/>
    NL,

    /// <remarks/>
    BQ,

    /// <remarks/>
    PK,

    /// <remarks/>
    PW,

    /// <remarks/>
    PA,

    /// <remarks/>
    PG,

    /// <remarks/>
    PY,

    /// <remarks/>
    PE,

    /// <remarks/>
    PN,

    /// <remarks/>
    PF,

    /// <remarks/>
    PL,

    /// <remarks/>
    PT,

    /// <remarks/>
    PR,

    /// <remarks/>
    QA,

    /// <remarks/>
    GB,

    /// <remarks/>
    RW,

    /// <remarks/>
    RO,

    /// <remarks/>
    RU,

    /// <remarks/>
    SB,

    /// <remarks/>
    SV,

    /// <remarks/>
    WS,

    /// <remarks/>
    AS,

    /// <remarks/>
    KN,

    /// <remarks/>
    SM,

    /// <remarks/>
    SX,

    /// <remarks/>
    PM,

    /// <remarks/>
    VC,

    /// <remarks/>
    SH,

    /// <remarks/>
    LC,

    /// <remarks/>
    ST,

    /// <remarks/>
    SN,

    /// <remarks/>
    RS,

    /// <remarks/>
    SC,

    /// <remarks/>
    SL,

    /// <remarks/>
    SG,

    /// <remarks/>
    SY,

    /// <remarks/>
    SO,

    /// <remarks/>
    LK,

    /// <remarks/>
    SZ,

    /// <remarks/>
    ZA,

    /// <remarks/>
    SD,

    /// <remarks/>
    SS,

    /// <remarks/>
    SE,

    /// <remarks/>
    CH,

    /// <remarks/>
    SR,

    /// <remarks/>
    TH,

    /// <remarks/>
    TW,

    /// <remarks/>
    TZ,

    /// <remarks/>
    TJ,

    /// <remarks/>
    PS,

    /// <remarks/>
    TF,

    /// <remarks/>
    TL,

    /// <remarks/>
    TG,

    /// <remarks/>
    TK,

    /// <remarks/>
    TO,

    /// <remarks/>
    TT,

    /// <remarks/>
    TN,

    /// <remarks/>
    TC,

    /// <remarks/>
    TM,

    /// <remarks/>
    TR,

    /// <remarks/>
    TV,

    /// <remarks/>
    UA,

    /// <remarks/>
    UG,

    /// <remarks/>
    UY,

    /// <remarks/>
    UZ,

    /// <remarks/>
    VU,

    /// <remarks/>
    VA,

    /// <remarks/>
    VE,

    /// <remarks/>
    VN,

    /// <remarks/>
    VG,

    /// <remarks/>
    VI,

    /// <remarks/>
    WF,

    /// <remarks/>
    YE,

    /// <remarks/>
    DJ,

    /// <remarks/>
    ZM,

    /// <remarks/>
    ZW,

    /// <remarks/>
    QU,

    /// <remarks/>
    XB,

    /// <remarks/>
    XU,

    /// <remarks/>
    XN,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(TypeName = "IDTypeType", Namespace = "urn:ticketbai:emision")]
public enum IDTypeType1
{

    /// <remarks/>
    [XmlEnum("02")]
    Item02,

    /// <remarks/>
    [XmlEnum("03")]
    Item03,

    /// <remarks/>
    [XmlEnum("04")]
    Item04,

    /// <remarks/>
    [XmlEnum("05")]
    Item05,

    /// <remarks/>
    [XmlEnum("06")]
    Item06,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum SiNoType
{

    /// <remarks/>
    S,

    /// <remarks/>
    N,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum EmitidaPorTercerosType
{

    /// <remarks/>
    N,

    /// <remarks/>
    T,

    /// <remarks/>
    D,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class Factura
{

    private CabeceraFacturaType1 cabeceraFacturaField;

    private DatosFacturaType datosFacturaField;

    private TipoDesgloseType tipoDesgloseField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CabeceraFacturaType1 CabeceraFactura
    {
        get
        {
            return cabeceraFacturaField;
        }
        set
        {
            cabeceraFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public DatosFacturaType DatosFactura
    {
        get
        {
            return datosFacturaField;
        }
        set
        {
            datosFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoDesgloseType TipoDesglose
    {
        get
        {
            return tipoDesgloseField;
        }
        set
        {
            tipoDesgloseField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "CabeceraFacturaType", Namespace = "urn:ticketbai:emision")]
public class CabeceraFacturaType1
{

    private string serieFacturaField;

    private string numFacturaField;

    private string fechaExpedicionFacturaField;

    private string horaExpedicionFacturaField;

    private SiNoType facturaSimplificadaField;

    private bool facturaSimplificadaFieldSpecified;

    private SiNoType facturaEmitidaSustitucionSimplificadaField;

    private bool facturaEmitidaSustitucionSimplificadaFieldSpecified;

    private FacturaRectificativaType facturaRectificativaField;

    private IDFacturaRectificadaSustituidaType[] facturasRectificadasSustituidasField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SerieFactura
    {
        get
        {
            return serieFacturaField;
        }
        set
        {
            serieFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumFactura
    {
        get
        {
            return numFacturaField;
        }
        set
        {
            numFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaExpedicionFactura
    {
        get
        {
            return fechaExpedicionFacturaField;
        }
        set
        {
            fechaExpedicionFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string HoraExpedicionFactura
    {
        get
        {
            return horaExpedicionFacturaField;
        }
        set
        {
            horaExpedicionFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SiNoType FacturaSimplificada
    {
        get
        {
            return facturaSimplificadaField;
        }
        set
        {
            facturaSimplificadaField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool FacturaSimplificadaSpecified
    {
        get
        {
            return facturaSimplificadaFieldSpecified;
        }
        set
        {
            facturaSimplificadaFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SiNoType FacturaEmitidaSustitucionSimplificada
    {
        get
        {
            return facturaEmitidaSustitucionSimplificadaField;
        }
        set
        {
            facturaEmitidaSustitucionSimplificadaField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool FacturaEmitidaSustitucionSimplificadaSpecified
    {
        get
        {
            return facturaEmitidaSustitucionSimplificadaFieldSpecified;
        }
        set
        {
            facturaEmitidaSustitucionSimplificadaFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public FacturaRectificativaType FacturaRectificativa
    {
        get
        {
            return facturaRectificativaField;
        }
        set
        {
            facturaRectificativaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem("IDFacturaRectificadaSustituida", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public IDFacturaRectificadaSustituidaType[] FacturasRectificadasSustituidas
    {
        get
        {
            return facturasRectificadasSustituidasField;
        }
        set
        {
            facturasRectificadasSustituidasField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class FacturaRectificativaType
{

    private ClaveTipoFacturaType codigoField;

    private ClaveTipoRectificativaType tipoField;

    private ImporteRectificacionSustitutivaType importeRectificacionSustitutivaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ClaveTipoFacturaType Codigo
    {
        get
        {
            return codigoField;
        }
        set
        {
            codigoField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ClaveTipoRectificativaType Tipo
    {
        get
        {
            return tipoField;
        }
        set
        {
            tipoField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ImporteRectificacionSustitutivaType ImporteRectificacionSustitutiva
    {
        get
        {
            return importeRectificacionSustitutivaField;
        }
        set
        {
            importeRectificacionSustitutivaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum ClaveTipoFacturaType
{

    /// <remarks/>
    R1,

    /// <remarks/>
    R2,

    /// <remarks/>
    R3,

    /// <remarks/>
    R4,

    /// <remarks/>
    R5,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum ClaveTipoRectificativaType
{

    /// <remarks/>
    S,

    /// <remarks/>
    I,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class ImporteRectificacionSustitutivaType
{

    private string baseRectificadaField;

    private string cuotaRectificadaField;

    private string cuotaRecargoRectificadaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BaseRectificada
    {
        get
        {
            return baseRectificadaField;
        }
        set
        {
            baseRectificadaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CuotaRectificada
    {
        get
        {
            return cuotaRectificadaField;
        }
        set
        {
            cuotaRectificadaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CuotaRecargoRectificada
    {
        get
        {
            return cuotaRecargoRectificadaField;
        }
        set
        {
            cuotaRecargoRectificadaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class IDFacturaRectificadaSustituidaType
{

    private string serieFacturaField;

    private string numFacturaField;

    private string fechaExpedicionFacturaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SerieFactura
    {
        get
        {
            return serieFacturaField;
        }
        set
        {
            serieFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumFactura
    {
        get
        {
            return numFacturaField;
        }
        set
        {
            numFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaExpedicionFactura
    {
        get
        {
            return fechaExpedicionFacturaField;
        }
        set
        {
            fechaExpedicionFacturaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DatosFacturaType
{

    private string fechaOperacionField;

    private string descripcionFacturaField;

    private IDDetalleFacturaType[] detallesFacturaField;

    private string importeTotalFacturaField;

    private string retencionSoportadaField;

    private string baseImponibleACosteField;

    private IDClaveType[] clavesField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaOperacion
    {
        get
        {
            return fechaOperacionField;
        }
        set
        {
            fechaOperacionField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DescripcionFactura
    {
        get
        {
            return descripcionFacturaField;
        }
        set
        {
            descripcionFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem("IDDetalleFactura", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public IDDetalleFacturaType[] DetallesFactura
    {
        get
        {
            return detallesFacturaField;
        }
        set
        {
            detallesFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ImporteTotalFactura
    {
        get
        {
            return importeTotalFacturaField;
        }
        set
        {
            importeTotalFacturaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RetencionSoportada
    {
        get
        {
            return retencionSoportadaField;
        }
        set
        {
            retencionSoportadaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BaseImponibleACoste
    {
        get
        {
            return baseImponibleACosteField;
        }
        set
        {
            baseImponibleACosteField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem("IDClave", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public IDClaveType[] Claves
    {
        get
        {
            return clavesField;
        }
        set
        {
            clavesField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class IDDetalleFacturaType
{

    private string descripcionDetalleField;

    private string cantidadField;

    private string importeUnitarioField;

    private string descuentoField;

    private string importeTotalField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DescripcionDetalle
    {
        get
        {
            return descripcionDetalleField;
        }
        set
        {
            descripcionDetalleField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Cantidad
    {
        get
        {
            return cantidadField;
        }
        set
        {
            cantidadField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ImporteUnitario
    {
        get
        {
            return importeUnitarioField;
        }
        set
        {
            importeUnitarioField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Descuento
    {
        get
        {
            return descuentoField;
        }
        set
        {
            descuentoField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ImporteTotal
    {
        get
        {
            return importeTotalField;
        }
        set
        {
            importeTotalField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class IDClaveType
{

    private IdOperacionesTrascendenciaTributariaType claveRegimenIvaOpTrascendenciaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenIvaOpTrascendencia
    {
        get
        {
            return claveRegimenIvaOpTrascendenciaField;
        }
        set
        {
            claveRegimenIvaOpTrascendenciaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum IdOperacionesTrascendenciaTributariaType
{

    /// <remarks/>
    [XmlEnum("01")]
    Item01,

    /// <remarks/>
    [XmlEnum("02")]
    Item02,

    /// <remarks/>
    [XmlEnum("03")]
    Item03,

    /// <remarks/>
    [XmlEnum("04")]
    Item04,

    /// <remarks/>
    [XmlEnum("05")]
    Item05,

    /// <remarks/>
    [XmlEnum("06")]
    Item06,

    /// <remarks/>
    [XmlEnum("07")]
    Item07,

    /// <remarks/>
    [XmlEnum("08")]
    Item08,

    /// <remarks/>
    [XmlEnum("09")]
    Item09,

    /// <remarks/>
    [XmlEnum("10")]
    Item10,

    /// <remarks/>
    [XmlEnum("11")]
    Item11,

    /// <remarks/>
    [XmlEnum("12")]
    Item12,

    /// <remarks/>
    [XmlEnum("13")]
    Item13,

    /// <remarks/>
    [XmlEnum("14")]
    Item14,

    /// <remarks/>
    [XmlEnum("15")]
    Item15,

    /// <remarks/>
    [XmlEnum("51")]
    Item51,

    /// <remarks/>
    [XmlEnum("52")]
    Item52,

    /// <remarks/>
    [XmlEnum("53")]
    Item53,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class TipoDesgloseType
{

    private object itemField;

    /// <remarks/>
    [XmlElement("DesgloseFactura", typeof(DesgloseFacturaType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlElement("DesgloseTipoOperacion", typeof(DesgloseTipoOperacionType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object Item
    {
        get
        {
            return itemField;
        }
        set
        {
            itemField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DesgloseFacturaType
{

    private SujetaType sujetaField;

    private DetalleNoSujeta[] noSujetaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SujetaType Sujeta
    {
        get
        {
            return sujetaField;
        }
        set
        {
            sujetaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public DetalleNoSujeta[] NoSujeta
    {
        get
        {
            return noSujetaField;
        }
        set
        {
            noSujetaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class SujetaType
{

    private DetalleExentaType[] exentaField;

    private DetalleNoExentaType[] noExentaField;

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem("DetalleExenta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public DetalleExentaType[] Exenta
    {
        get
        {
            return exentaField;
        }
        set
        {
            exentaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem("DetalleNoExenta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public DetalleNoExentaType[] NoExenta
    {
        get
        {
            return noExentaField;
        }
        set
        {
            noExentaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DetalleExentaType
{

    private CausaExencionType causaExencionField;

    private string baseImponibleField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CausaExencionType CausaExencion
    {
        get
        {
            return causaExencionField;
        }
        set
        {
            causaExencionField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BaseImponible
    {
        get
        {
            return baseImponibleField;
        }
        set
        {
            baseImponibleField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum CausaExencionType
{

    /// <remarks/>
    E1,

    /// <remarks/>
    E2,

    /// <remarks/>
    E3,

    /// <remarks/>
    E4,

    /// <remarks/>
    E5,

    /// <remarks/>
    E6,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DetalleNoExentaType
{

    private TipoOperacionSujetaNoExentaType tipoNoExentaField;

    private DetalleIVAType[] desgloseIVAField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoOperacionSujetaNoExentaType TipoNoExenta
    {
        get
        {
            return tipoNoExentaField;
        }
        set
        {
            tipoNoExentaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem("DetalleIVA", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public DetalleIVAType[] DesgloseIVA
    {
        get
        {
            return desgloseIVAField;
        }
        set
        {
            desgloseIVAField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum TipoOperacionSujetaNoExentaType
{

    /// <remarks/>
    S1,

    /// <remarks/>
    S2,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DetalleIVAType
{

    private string baseImponibleField;

    private string tipoImpositivoField;

    private string cuotaImpuestoField;

    private string tipoRecargoEquivalenciaField;

    private string cuotaRecargoEquivalenciaField;

    private SiNoType operacionEnRecargoDeEquivalenciaORegimenSimplificadoField;

    private bool operacionEnRecargoDeEquivalenciaORegimenSimplificadoFieldSpecified;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BaseImponible
    {
        get
        {
            return baseImponibleField;
        }
        set
        {
            baseImponibleField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TipoImpositivo
    {
        get
        {
            return tipoImpositivoField;
        }
        set
        {
            tipoImpositivoField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CuotaImpuesto
    {
        get
        {
            return cuotaImpuestoField;
        }
        set
        {
            cuotaImpuestoField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TipoRecargoEquivalencia
    {
        get
        {
            return tipoRecargoEquivalenciaField;
        }
        set
        {
            tipoRecargoEquivalenciaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CuotaRecargoEquivalencia
    {
        get
        {
            return cuotaRecargoEquivalenciaField;
        }
        set
        {
            cuotaRecargoEquivalenciaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SiNoType OperacionEnRecargoDeEquivalenciaORegimenSimplificado
    {
        get
        {
            return operacionEnRecargoDeEquivalenciaORegimenSimplificadoField;
        }
        set
        {
            operacionEnRecargoDeEquivalenciaORegimenSimplificadoField = value;
        }
    }

    /// <remarks/>
    [XmlIgnore]
    public bool OperacionEnRecargoDeEquivalenciaORegimenSimplificadoSpecified
    {
        get
        {
            return operacionEnRecargoDeEquivalenciaORegimenSimplificadoFieldSpecified;
        }
        set
        {
            operacionEnRecargoDeEquivalenciaORegimenSimplificadoFieldSpecified = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DetalleNoSujeta
{

    private CausaNoSujetaType causaField;

    private string importeField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CausaNoSujetaType Causa
    {
        get
        {
            return causaField;
        }
        set
        {
            causaField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Importe
    {
        get
        {
            return importeField;
        }
        set
        {
            importeField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "urn:ticketbai:emision")]
public enum CausaNoSujetaType
{

    /// <remarks/>
    OT,

    /// <remarks/>
    RL,
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class DesgloseTipoOperacionType
{

    private PrestacionServicios prestacionServiciosField;

    private Entrega entregaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public PrestacionServicios PrestacionServicios
    {
        get
        {
            return prestacionServiciosField;
        }
        set
        {
            prestacionServiciosField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Entrega Entrega
    {
        get
        {
            return entregaField;
        }
        set
        {
            entregaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class PrestacionServicios
{

    private SujetaType sujetaField;

    private DetalleNoSujeta[] noSujetaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SujetaType Sujeta
    {
        get
        {
            return sujetaField;
        }
        set
        {
            sujetaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public DetalleNoSujeta[] NoSujeta
    {
        get
        {
            return noSujetaField;
        }
        set
        {
            noSujetaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class Entrega
{

    private SujetaType sujetaField;

    private DetalleNoSujeta[] noSujetaField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SujetaType Sujeta
    {
        get
        {
            return sujetaField;
        }
        set
        {
            sujetaField = value;
        }
    }

    /// <remarks/>
    [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlArrayItem(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public DetalleNoSujeta[] NoSujeta
    {
        get
        {
            return noSujetaField;
        }
        set
        {
            noSujetaField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "HuellaTBAI", Namespace = "urn:ticketbai:emision")]
public class HuellaTBAI1
{

    private EncadenamientoFacturaAnteriorType encadenamientoFacturaAnteriorField;

    private SoftwareFacturacionType1 softwareField;

    private string numSerieDispositivoField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public EncadenamientoFacturaAnteriorType EncadenamientoFacturaAnterior
    {
        get
        {
            return encadenamientoFacturaAnteriorField;
        }
        set
        {
            encadenamientoFacturaAnteriorField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public SoftwareFacturacionType1 Software
    {
        get
        {
            return softwareField;
        }
        set
        {
            softwareField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumSerieDispositivo
    {
        get
        {
            return numSerieDispositivoField;
        }
        set
        {
            numSerieDispositivoField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:ticketbai:emision")]
public class EncadenamientoFacturaAnteriorType
{

    private string serieFacturaAnteriorField;

    private string numFacturaAnteriorField;

    private string fechaExpedicionFacturaAnteriorField;

    private string signatureValueFirmaFacturaAnteriorField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SerieFacturaAnterior
    {
        get
        {
            return serieFacturaAnteriorField;
        }
        set
        {
            serieFacturaAnteriorField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumFacturaAnterior
    {
        get
        {
            return numFacturaAnteriorField;
        }
        set
        {
            numFacturaAnteriorField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaExpedicionFacturaAnterior
    {
        get
        {
            return fechaExpedicionFacturaAnteriorField;
        }
        set
        {
            fechaExpedicionFacturaAnteriorField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SignatureValueFirmaFacturaAnterior
    {
        get
        {
            return signatureValueFirmaFacturaAnteriorField;
        }
        set
        {
            signatureValueFirmaFacturaAnteriorField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "SoftwareFacturacionType", Namespace = "urn:ticketbai:emision")]
public class SoftwareFacturacionType1
{

    private string licenciaTBAIField;

    private EntidadDesarrolladoraType1 entidadDesarrolladoraField;

    private string nombreField;

    private string versionField;

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LicenciaTBAI
    {
        get
        {
            return licenciaTBAIField;
        }
        set
        {
            licenciaTBAIField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public EntidadDesarrolladoraType1 EntidadDesarrolladora
    {
        get
        {
            return entidadDesarrolladoraField;
        }
        set
        {
            entidadDesarrolladoraField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Nombre
    {
        get
        {
            return nombreField;
        }
        set
        {
            nombreField = value;
        }
    }

    /// <remarks/>
    [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }
}

/// <remarks/>
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[DesignerCategory("code")]
[XmlType(TypeName = "EntidadDesarrolladoraType", Namespace = "urn:ticketbai:emision")]
public class EntidadDesarrolladoraType1
{

    private object itemField;

    /// <remarks/>
    [XmlElement("IDOtro", typeof(IDOtro1), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [XmlElement("NIF", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object Item
    {
        get
        {
            return itemField;
        }
        set
        {
            itemField = value;
        }
    }
}