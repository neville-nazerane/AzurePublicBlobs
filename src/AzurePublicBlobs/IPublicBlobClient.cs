using AzurePublicBlobs.Models;

namespace AzurePublicBlobs
{
    public interface IPublicBlobClient
    {
        Task<BlobEnumerations> GetContainerContentsAsync(int maxResults = 5000, string marker = null, string prefix = null, string include = null);
        Task<BlobEnumerations<TMetadata>> GetContainerContentsAsync<TMetadata>(int maxResults = 5000, string marker = null, string prefix = null);
    }
}