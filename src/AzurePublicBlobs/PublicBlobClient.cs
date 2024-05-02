using AzurePublicBlobs.Models;
using AzurePublicBlobs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurePublicBlobs
{
    public class PublicBlobClient(HttpClient httpClient) : IPublicBlobClient
    {

        private readonly HttpClient _httpClient = httpClient;

        public Task<BlobEnumerations> GetContainerContentsAsync(string fullUrlOfContainer,
                                                                int maxResults = 5000,
                                                                string marker = null,
                                                                string prefix = null,
                                                                string include = null)
            => _httpClient.GetAsXMLAsync<BlobEnumerations>(
                    $"{fullUrlOfContainer}?restype=container&comp=list&include={include}&maxResults={maxResults}&marker={marker}&prefix={prefix}");

        public Task<BlobEnumerations<TMetadata>> GetContainerContentsAsync<TMetadata>(string fullUrlOfContainer,
                                                                                      int maxResults = 5000,
                                                                                      string marker = null,
                                                                                      string prefix = null)
            => _httpClient.GetAsXMLAsync<BlobEnumerations<TMetadata>>(
                    $"{fullUrlOfContainer}?restype=container&comp=list&include=metadata&maxResults={maxResults}&marker={marker}&prefix={prefix}");

    }
}
