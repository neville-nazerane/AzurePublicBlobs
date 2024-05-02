using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzurePublicBlobs.Utils
{
    internal static class HttpExtensions
    {

        internal static async Task<TModel> GetAsXMLAsync<TModel>(this HttpClient httpClient, string url) where TModel : class
        {
            using HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            XmlSerializer serializer = new(typeof(TModel));
            await using Stream responseStream = await response.Content.ReadAsStreamAsync();
            return (TModel)serializer.Deserialize(responseStream);
        }

    }
}
