
# Access Azure Public blobs
Utility for api calls 
Indended to be used by C# client side apps such as maui or blazor apps


[![Build Status](https://dev.azure.com/nevillenazerane/publishes/_apis/build/status%2Fnugets%2FAzurePublicBlobs%20Nuget?branchName=master)](https://dev.azure.com/nevillenazerane/publishes/_build/latest?definitionId=83&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/AzurePublicBlobs.svg)](https://www.nuget.org/packages/AzurePublicBlobs/)


## Quick Start


### Install the nuget

```
dotnet add package AzurePublicBlobs
```

### Setting up PublicBlobClient

```csharp 
HttpClient httpClient = new();
IPublicBlobClient client = new PublicBlobClient(httpClient);

// OR for web projects
services.AddHttpClient<IPublicBlobClient, PublicBlobClient>();
```

### Getting blobs

```csharp
var blobItems = await client.GetContainerContentsAsync("http://fullblockUrl.com");

foreach (var item in blobItems.Blobs)
    Console.WriteLine(item.Name);
```