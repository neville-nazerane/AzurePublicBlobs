using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzurePublicBlobs.Models
{

    [XmlRoot(ElementName = "EnumerationResults")]
    public class BlobEnumerations
    {

        [XmlIgnore]
        public IEnumerable<BlobData> Blobs => BlobsInternal?.Blobs;

        [XmlElement(ElementName = "Blobs")]
        public BlobsModel BlobsInternal { get; set; }

        [XmlAttribute("ContainerName")]
        public string ContainerName { get; set; }

        [XmlAttribute("NextMarker")]
        public string NextMarker { get; set; }

        [XmlAttribute("MaxResults")]
        public int MaxResults { get; set; }
    }

    public class BlobEnumerations<TMetadata> : BlobEnumerations
    {

        [XmlIgnore]
        public new IEnumerable<BlobData<TMetadata>> Blobs => BlobsInternal?.Blobs;

        [XmlElement(ElementName = "Blobs")]
        public new BlobsModel<TMetadata> BlobsInternal { get; set; }

    }

}
