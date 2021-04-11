using Azure.Storage.Blobs;
using System.IO;

namespace ServerHandling.Database
{
    public class BlobsManager
    {
        private const string connectionString = @"DefaultEndpointsProtocol=https;AccountName=risethesummer;AccountKey=qIg6ehNaX8hv4a1j/2MSBQBMa0oj/JB34hPDp7InpPYBXM6qSdHAFqI+/wZtgvodGm1PbrgVBfnqV4TM043cHA==;EndpointSuffix=core.windows.net";

        private readonly BlobServiceClient blobServiceClient;

        public BlobsManager()
        {
            blobServiceClient = new BlobServiceClient(connectionString);
        }

        public bool UploadFileOnAzure(string container, string fileName, string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                var containerClient = blobServiceClient.GetBlobContainerClient(container);
                try
                {
                    containerClient.CreateIfNotExists();
                    containerClient.UploadBlob(fileName, stream);
                    return true;
                }
                catch (Azure.RequestFailedException)
                {
                    return false;
                }
            }
        }
        public void DeleteFileOnAzure(string container, string fileName)
        {
            var containerClient = blobServiceClient.GetBlobContainerClient(container);
            if (containerClient.Exists())
                containerClient.DeleteBlobIfExists(fileName);
        }
    }
}