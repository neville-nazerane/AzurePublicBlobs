using AzurePublicBlobs;



HttpClient httpClient = new();
IPublicBlobClient client = new PublicBlobClient(httpClient);

var blobItems = await client.GetContainerContentsAsync("http://fullblockUrl.com");

foreach (var item in blobItems.Blobs)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Url);
    Console.WriteLine(item.Properties?.LastModified);
}

var blobItemsWithMeta = await client.GetContainerContentsAsync<MyMeta>("http://fullblockUrl.com");

foreach (var item in blobItemsWithMeta.Blobs)
    Console.WriteLine(item.Metadata.Description);

var page1 = await client.GetContainerContentsAsync("http://fullblockUrl.com/path/containerName",
                                                   maxResults: 10);

var page2 = await client.GetContainerContentsAsync("http://fullblockUrl.com/path/containerName",
                                                   maxResults: 10,
                                                   marker: page1.NextMarker);

class MyMeta
{
    public string Description { get; set; }

}


