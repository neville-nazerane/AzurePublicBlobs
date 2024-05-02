using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzurePublicBlobs.Models
{


    public class Blobs
    {

        [XmlElement(ElementName = "Blob")]
        public IEnumerable<BlobData> Blob { get; set; }

    }

    public class Blobs<TMetadata>
    {

        [XmlElement(ElementName = "Blob")]
        public IEnumerable<BlobData<TMetadata>> Blob { get; set; }

    }


}
