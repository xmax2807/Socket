using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace ServerHandling.Database
{
    public class DatabaseManager
    {
        public static string GetConnectString(string name)
       => ConfigurationManager.ConnectionStrings[name].ConnectionString;

        private readonly BlobsManager blobsManager = new BlobsManager(GetConnectString("Azure"));

        public readonly SQLServerManager sqlManager = new SQLServerManager(GetConnectString("SQL"));

        //Get name for a container on azure
        private readonly Dictionary<string, string> containerNameFromType = new Dictionary<string, string>()
        {
            {"Công Nghệ Thông Tin", "cong-nghe-thong-tin" }
        };


        //Succefully add or not
        public bool InsertNewBook(Book book)
        {
            #region SQL
            if (!sqlManager.InsertNewBook(book))
                return false;
            #endregion

            #region Azure
            string container = containerNameFromType[book.typeName]; //Container of blob
            string fileName = book.authorName + book.name; //Name of blob
            return blobsManager.UploadFileOnAzure(container, fileName, book.filePath);
            #endregion
        }

        public bool InsertNewUser(CommonResource.User user)
        {
            //Hash password to byte[16] by MD5 algorithm
            using (var md5 = MD5.Create())
            {
                var ePassword = md5.ComputeHash(Encoding.ASCII.GetBytes(user.Password));
                return sqlManager.InsertNewUser(user.UserName, ePassword);
            }
        }
    }
}
