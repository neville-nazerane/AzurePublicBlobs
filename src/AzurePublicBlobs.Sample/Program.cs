using AzurePublicBlobs;



HttpClient httpClient = new();
IPublicBlobClient client = new PublicBlobClient(httpClient);

var blobItems = await client.GetContainerContentsAsync("http://fullblockUrl.com");

foreach (var item in blobItems.Blobs)
    Console.WriteLine(item.Name);

var blobItemsWithMeta = await client.GetContainerContentsAsync<MyMeta>("http://fullblockUrl.com");

foreach (var item in blobItemsWithMeta.Blobs)
    Console.WriteLine(item.Metadata.Description);

class MyMeta
{
    public string Description { get; set; }

}