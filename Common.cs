using System.Threading;

namespace buluton.ndef
{
    public enum ShareParam : uint
    {
        Exclusive = 0x00000001,
        Shared = 0x00000002,
        Direct = 0x00000003
    };

    public enum Protocol : uint
    {
        Undefined = 0x00000000,
        T0 = 0x00000001,
        T1 = 0x00000002,
        Raw = 0x00000004
    };

    public enum Disposition : int
    {
        Leave = 0x00000000,
        Reset = 0x00000001,
        Unpower = 0x00000002,
        Eject = 0x00000003
    };

    public enum CardState : uint
    {
        Unaware = 0x00000000,
        Empty = 0x00000010,
        Present = 0x00000020,
    };

    public enum CardEvent : uint
    {
        StateChanged = 0x00000002,
    };

    public enum Scope : uint
    {
        User = 0x00000000,
        Terminal = 0x00000001,
        System = 0x00000002
    };

    public enum ErrorCode : uint
    {
        NoError = 0x00000000,
        NoService = 0x8010001D,
        Timeout = 0x8010000A
    };

    public enum ExecStatus : uint
    {
        Success = 0,
        Warning,
        Error,
    };

    public enum CardType : byte
    {
        Unknown = 0x00,
        Iso14443a = 0x01,
        Iso14443b = 0x02,
        PicoPassB = 0x03,
        Felica = 0x04,
        NfcType1 = 0x05,
        MifareEc = 0x06,
        Iso14443a4A = 0x07,
        Iso14443b4B = 0x08,
        TypeANefDep = 0x09,
        FelicaNefDep = 0x0A,
    };

    public enum Attribute : uint
    {
        VendorIfdSerialNo = 0x00010103,
    };

    public enum TlvTag : byte
    {
        Null = 0x00,
        LockControl = 0x01,
        MemoryControl = 0x02,
        NdefMessage = 0x03,
        Proprietary = 0xfd,
        Terminator = 0xfe,
    };

    public enum TypeNameFormat : byte
    {
        Empty = 0x00,
        NfcForumWellKnownType = 0x01,
        MediaTypeAsDefineInRfc2046 = 0x02,
        AbsoluteUriAsDefineInRfc3986 = 0x03,
        NfcForumExternalType = 0x04,
        Unknown = 0x05,
        Unchanged = 0x06,
        Recerved = 0x07
    };

    public enum UriPrefix : byte
    {
        Null = 0x00,
        HttpWww = 0x01,
        HttpsWww = 0x02,
        Http = 0x03,
        Https = 0x04,
        Tel = 0x05,
        MailTo = 0x06,
        FtpAnonymous = 0x07,
        FtpFtp = 0x08,
        Ftps = 0x09,
        Sftp = 0x0a,
        Smb = 0x0b,
        Nfs = 0x0c,
        Ftp = 0x0d,
        Dav = 0x0e,
        News = 0x0f,
        Telnet = 0x10,
        Imap = 0x11,
        Rtsp = 0x12,
        Urn = 0x13,
        Pop = 0x14,
        Sip = 0x15,
        Sips = 0x16,
        Tftp = 0x17,
        Btspp = 0x18,
        Btl2cap = 0x19,
        Btgoep = 0x1a,
        Tcpobex = 0x1b,
        Irdaobex = 0x1c,
        File = 0x1d,
        UrnEpcId = 0x1e,
        UrnEpcTag = 0x1f,
        UrnEpcPat = 0x20,
        UrnEpcRaw = 0x21,
        UrnEpc = 0x22,
        UrnNfc = 0x23,
    };

    public static class Global
    {
        public static SynchronizationContext SyncContext { get; set; }
        public static bool UseSyncContextPost = true;

        public static string UriPrefixString(UriPrefix prefix)
        {
            switch (prefix)
            {
                case UriPrefix.Null:
                    return "";
                case UriPrefix.HttpWww:
                    return "http://www.";
                case UriPrefix.HttpsWww:
                    return "https://www.";
                case UriPrefix.Http:
                    return "http://";
                case UriPrefix.Https:
                    return "https://";
                case UriPrefix.Tel:
                    return "tel:";
                case UriPrefix.MailTo:
                    return "mailto:";
                case UriPrefix.FtpAnonymous:
                    return "ftp://anonymous:anonymous@";
                case UriPrefix.FtpFtp:
                    return "ftp://ftp.";
                case UriPrefix.Ftps:
                    return "ftps://";
                case UriPrefix.Sftp:
                    return "sftp://";
                case UriPrefix.Smb:
                    return "smb://";
                case UriPrefix.Nfs:
                    return "nfs://";
                case UriPrefix.Ftp:
                    return "ftp://";
                case UriPrefix.Dav:
                    return "dav://";
                case UriPrefix.News:
                    return "news:";
                case UriPrefix.Telnet:
                    return "telnet://";
                case UriPrefix.Imap:
                    return "imap:";
                case UriPrefix.Rtsp:
                    return "rtsp://";
                case UriPrefix.Urn:
                    return "urn:";
                case UriPrefix.Pop:
                    return "pop:";
                case UriPrefix.Sip:
                    return "sip:";
                case UriPrefix.Sips:
                    return "sips:";
                case UriPrefix.Tftp:
                    return "tftp:";
                case UriPrefix.Btspp:
                    return "btspp://";
                case UriPrefix.Btl2cap:
                    return "btl2cap://";
                case UriPrefix.Btgoep:
                    return "btgoep://";
                case UriPrefix.Tcpobex:
                    return "tcpobex://";
                case UriPrefix.Irdaobex:
                    return "irdaobex://";
                case UriPrefix.File:
                    return "file://";
                case UriPrefix.UrnEpcId:
                    return "urn:epc:id:";
                case UriPrefix.UrnEpcTag:
                    return "urn:epc:tag:";
                case UriPrefix.UrnEpcPat:
                    return "urn:epc:pat:";
                case UriPrefix.UrnEpcRaw:
                    return "urn:epc:raw:";
                case UriPrefix.UrnEpc:
                    return "urn:epc:";
                case UriPrefix.UrnNfc:
                    return "urn:nfc:";
                default:
                    return "";
            }
        }

        public static UriPrefix UriPrefixStringForUrl(string url)
        {
            if (url.StartsWith("http://www."))
            {
                return UriPrefix.HttpWww;
            }
            else if (url.StartsWith("https://www."))
            {
                return UriPrefix.HttpsWww;
            }
            else if (url.StartsWith("http://"))
            {
                return UriPrefix.Http;
            }
            else if (url.StartsWith("https://"))
            {
                return UriPrefix.Https;
            }
            else if (url.StartsWith("tel:"))
            {
                return UriPrefix.Tel;
            }
            else if (url.StartsWith("mailto:"))
            {
                return UriPrefix.MailTo;
            }
            else if (url.StartsWith("ftp://anonymous:anonymous@"))
            {
                return UriPrefix.FtpAnonymous;
            }
            else if (url.StartsWith("ftp://ftp."))
            {
                return UriPrefix.FtpFtp;
            }
            else if (url.StartsWith("ftps://"))
            {
                return UriPrefix.Ftps;
            }
            else if (url.StartsWith("sftp://"))
            {
                return UriPrefix.Sftp;
            }
            else if (url.StartsWith("smb://"))
            {
                return UriPrefix.Smb;
            }
            else if (url.StartsWith("nfs://"))
            {
                return UriPrefix.Nfs;
            }
            else if (url.StartsWith("ftp://"))
            {
                return UriPrefix.Ftp;
            }
            else if (url.StartsWith("dav://"))
            {
                return UriPrefix.Dav;
            }
            else if (url.StartsWith("news:"))
            {
                return UriPrefix.News;
            }
            else if (url.StartsWith("telnet://"))
            {
                return UriPrefix.Telnet;
            }
            else if (url.StartsWith("imap:"))
            {
                return UriPrefix.Imap;
            }
            else if (url.StartsWith("rtsp://"))
            {
                return UriPrefix.Rtsp;
            }
            else if (url.StartsWith("urn:"))
            {
                return UriPrefix.Urn;
            }
            else if (url.StartsWith("pop:"))
            {
                return UriPrefix.Pop;
            }
            else if (url.StartsWith("sip:"))
            {
                return UriPrefix.Sip;
            }
            else if (url.StartsWith("sips:"))
            {
                return UriPrefix.Sips;
            }
            else if (url.StartsWith("tftp:"))
            {
                return UriPrefix.Tftp;
            }
            else if (url.StartsWith("btspp://"))
            {
                return UriPrefix.Btspp;
            }
            else if (url.StartsWith("btl2cap://"))
            {
                return UriPrefix.Btl2cap;
            }
            else if (url.StartsWith("btgoep://"))
            {
                return UriPrefix.Btgoep;
            }
            else if (url.StartsWith("tcpobex://"))
            {
                return UriPrefix.Tcpobex;
            }
            else if (url.StartsWith("irdaobex://"))
            {
                return UriPrefix.Irdaobex;
            }
            else if (url.StartsWith("file://"))
            {
                return UriPrefix.File;
            }
            else if (url.StartsWith("urn:epc:id:"))
            {
                return UriPrefix.UrnEpcId;
            }
            else if (url.StartsWith("urn:epc:tag:"))
            {
                return UriPrefix.UrnEpcTag;
            }
            else if (url.StartsWith("urn:epc:pat:"))
            {
                return UriPrefix.UrnEpcPat;
            }
            else if (url.StartsWith("urn:epc:raw:"))
            {
                return UriPrefix.UrnEpcRaw;
            }
            else if (url.StartsWith("urn:epc:"))
            {
                return UriPrefix.UrnEpc;
            }
            else if (url.StartsWith("urn:nfc:"))
            {
                return UriPrefix.UrnNfc;
            }
            else
            {
                return UriPrefix.Null;
            }
        }

        public static string UriPrefixClearForUrl(string url)
        {
            if (url.StartsWith("http://www."))
            {
                return url.Replace("http://www.", "");
            }
            else if (url.StartsWith("https://www."))
            {
                return url.Replace("https://www.", "");
            }
            else if (url.StartsWith("http://"))
            {
                return url.Replace("http://", "");
            }
            else if (url.StartsWith("https://"))
            {
                return url.Replace("https://", "");
            }
            else if (url.StartsWith("tel:"))
            {
                return url.Replace("tel:", "");
            }
            else if (url.StartsWith("mailto:"))
            {
                return url.Replace("mailto:", "");
            }
            else if (url.StartsWith("ftp://anonymous:anonymous@"))
            {
                return url.Replace("ftp://anonymous:anonymous@", "");
            }
            else if (url.StartsWith("ftp://ftp."))
            {
                return url.Replace("ftp://ftp.", "");
            }
            else if (url.StartsWith("ftps://"))
            {
                return url.Replace("ftps://", "");
            }
            else if (url.StartsWith("sftp://"))
            {
                return url.Replace("sftp://", "");
            }
            else if (url.StartsWith("smb://"))
            {
                return url.Replace("smb://", "");
            }
            else if (url.StartsWith("nfs://"))
            {
                return url.Replace("nfs://", "");
            }
            else if (url.StartsWith("ftp://"))
            {
                return url.Replace("ftp://", "");
            }
            else if (url.StartsWith("dav://"))
            {
                return url.Replace("dav://", "");
            }
            else if (url.StartsWith("news:"))
            {
                return url.Replace("news:", "");
            }
            else if (url.StartsWith("telnet://"))
            {
                return url.Replace("telnet://", "");
            }
            else if (url.StartsWith("imap:"))
            {
                return url.Replace("imap:", "");
            }
            else if (url.StartsWith("rtsp://"))
            {
                return url.Replace("rtsp://", "");
            }
            else if (url.StartsWith("urn:"))
            {
                return url.Replace("urn:", "");
            }
            else if (url.StartsWith("pop:"))
            {
                return url.Replace("pop:", "");
            }
            else if (url.StartsWith("sip:"))
            {
                return url.Replace("sip:", "");
            }
            else if (url.StartsWith("sips:"))
            {
                return url.Replace("sips:", "");
            }
            else if (url.StartsWith("tftp:"))
            {
                return url.Replace("tftp:", "");
            }
            else if (url.StartsWith("btspp://"))
            {
                return url.Replace("btspp://", "");
            }
            else if (url.StartsWith("btl2cap://"))
            {
                return url.Replace("btl2cap://", "");
            }
            else if (url.StartsWith("btgoep://"))
            {
                return url.Replace("btgoep://", "");
            }
            else if (url.StartsWith("tcpobex://"))
            {
                return url.Replace("tcpobex://", "");
            }
            else if (url.StartsWith("irdaobex://"))
            {
                return url.Replace("irdaobex://", "");
            }
            else if (url.StartsWith("file://"))
            {
                return url.Replace("file://", "");
            }
            else if (url.StartsWith("urn:epc:id:"))
            {
                return url.Replace("urn:epc:id:", "");
            }
            else if (url.StartsWith("urn:epc:tag:"))
            {
                return url.Replace("urn:epc:tag:", "");
            }
            else if (url.StartsWith("urn:epc:pat:"))
            {
                return url.Replace("urn:epc:pat:", "");
            }
            else if (url.StartsWith("urn:epc:raw:"))
            {
                return url.Replace("urn:epc:raw:", "");
            }
            else if (url.StartsWith("urn:epc:"))
            {
                return url.Replace("urn:epc:", "");
            }
            else if (url.StartsWith("urn:nfc:"))
            {
                return url.Replace("urn:nfc:", "");
            }
            else
            {
                return url;
            }
        }
    }
}
