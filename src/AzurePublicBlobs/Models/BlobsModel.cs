using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzurePublicBlobs.Models
{


    public class BlobsModel
    {

        [XmlElement(ElementName = "Blob")]
        public List<BlobData> Blobs { get; set; }

    }

    public class BlobsModel<TMetadata>
    {

        [XmlElement(ElementName = "Blob")]
        public List<BlobData<TMetadata>> Blobs { get; set; }

    }


}
