using Azure.Storage.Blobs;
using System.IO;

namespace ServerHandling.Database
{
    public class BlobsManager
    {
        private readonly BlobServiceClient blobServiceClient;
        public BlobsManager(string connectionString)
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
                    if (containerClient.Exists())
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