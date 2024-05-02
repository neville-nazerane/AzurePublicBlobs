using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzurePublicBlobs.Models
{

    public class Properties
    {
        [XmlElement("Last-Modified")]
        public string LastModified { get; set; }

        [XmlElement("Etag")]
        public string Etag { get; set; }

        [XmlElement("Content-Length")]
        public int ContentLength { get; set; }

        [XmlElement("Content-Type")]
        public string ContentType { get; set; }

        [XmlElement("Content-MD5")]
        public string ContentMD5 { get; set; }

        [XmlElement("BlobType")]
        public string BlobType { get; set; }

        [XmlElement("LeaseStatus")]
        public string LeaseStatus { get; set; }
    }
}
