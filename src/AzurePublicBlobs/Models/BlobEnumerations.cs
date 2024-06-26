﻿using System;
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

        [XmlElement(ElementName = "Blobs")]
        public BlobsModel Blobs { get; set; }

        [XmlAttribute("ContainerName")]
        public string ContainerName { get; set; }

        [XmlAttribute("NextMarker")]
        public string NextMarker { get; set; }

        [XmlAttribute("MaxResults")]
        public int MaxResults { get; set; }
    }

    public class BlobEnumerations<TMetadata> : BlobEnumerations
    {

        [XmlElement(ElementName = "Blobs")]
        public new BlobsModel<TMetadata> Blobs { get; set; }

    }

}
