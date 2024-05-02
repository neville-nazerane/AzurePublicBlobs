using AzurePublicBlobs.Models;
using AzurePublicBlobs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurePublicBlobs
{
    public class PublicBlobClient(HttpClient httpClient, string fullUrlOfContainer) : IPublicBlobClient
    {

        private readonly HttpClient _httpClient = httpClient;
        private readonly string _fullUrlOfContainer = fullUrlOfContainer;

        public Task<BlobEnumerations> GetContainerContentsAsync(int maxResults = 5000,
                                                                string marker = null,
                                                                string prefix = null,
                                                                string include = null)
            => _httpClient.GetAsXMLAsync<BlobEnumerations>(
                    $"{_fullUrlOfContainer}?restype=container&comp=list&include={include}&maxResults={maxResults}&marker={marker}&prefix={prefix}");

        public Task<BlobEnumerations<TMetadata>> GetContainerContentsAsync<TMetadata>(int maxResults = 5000,
                                                                                      string marker = null,
                                                                                      string prefix = null)
            => _httpClient.GetAsXMLAsync<BlobEnumerations<TMetadata>>(
                    $"{_fullUrlOfContainer}?restype=container&comp=list&include=metadata&maxResults={maxResults}&marker={marker}&prefix={prefix}");

    }
}
