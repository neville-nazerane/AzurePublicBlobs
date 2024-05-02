using AzurePublicBlobs.Models;

namespace AzurePublicBlobs
{
    public interface IPublicBlobClient
    {
        Task<BlobEnumerations> GetContainerContentsAsync(string fullUrlOfContainer, int maxResults = 5000, string marker = null, string prefix = null, string include = null);
        Task<BlobEnumerations<TMetadata>> GetContainerContentsAsync<TMetadata>(string fullUrlOfContainer, int maxResults = 5000, string marker = null, string prefix = null);
    }
}