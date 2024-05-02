using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzurePublicBlobs.Models
{
    public class BlobData
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Url")]
        public string Url { get; set; }

        [XmlElement("Properties")]
        public Properties Properties { get; set; }

    }

    public class BlobData<TMetaData> : BlobData
    {

        [XmlElement("Metadata")]
        public TMetaData Metadata { get; set; }
    }


}
