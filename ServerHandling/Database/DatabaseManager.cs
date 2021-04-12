using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace ServerHandling.Database
{
    public class DatabaseManager
    {

        private readonly BlobsManager blobsManager = new BlobsManager();

        private readonly SQLServerManager sqlManager = new SQLServerManager();

        //Get name for a container on azure
        private readonly Dictionary<string, string> containerNameFromType = new Dictionary<string, string>()
            {
                {"Công Nghệ Thông Tin", "cong-nghe-thong-tin" },
                { "Ẩm thực - Nấu ăn", "am-thuc-nau-an" },
                { "Cổ Tích - Thần Thoại", "co-tich-than-thoai" },
                {   "Học Ngoại Ngữ", "hoc-ngoai-ngu" },
                {"Hồi Ký - Tuỳ Bút", "hoi-ky-tuy-but" },
                {"Huyền bí - Giả Tưởng", "huyen-bi-gia-tuong" },
                {"Khoa Học - Kỹ Thuật", "khoa-hoc-ki-thuat" },
                {"Kiếm Hiệp - Tiên Hiệp", "kiem-hiep-tien-hiep" },
                {"Kiến Trúc - Xây Dựng", "kien-truc-xay-dung" },
                {"Kinh Tế - Quản Lý", "kinh-te-quan-ly" },
                {"Lịch Sử - Chính Trị", "lich-su-chinh-tri" },
                {"Marketing - Bán hàng", "makerting-ban-hang" },
                {"Nông - Lâm - Ngư","nong-lam-ngu" },
                {"Phiêu Lưu - Mạo Hiểm", "phieu-luu-mao-hiem" },
                {"Tài Liệu Học Tập", "tai-lieu-hoc-tap" },
                {"Thể Thao - Nghệ Thuật", "the-thao-nghe-thuat" },
                {"Thư Viện Pháp Luật", "thu-vien-phap-luat" },
                {"Tiểu Thuyết Phương Tây", "tieu-thuyet-phuong-tay" },
                {"Tiểu Thuyết Trung Quốc", "tieu-thuyet-trung-quoc" },
                {"Triết Học", "triet-hoc" },
                {"Trinh Thám - Hình Sự", "trinh-tham-hinh-su" },
                {"Truyện Cười - Tiếu Lâm", "truyen-cuoi-tieu-lam" },
                {"Truyện Ma - Truyện Kinh Dị", "truyen-ma-truyen-kinh-di" },
                {"Truyện Ngắn - Ngôn Tình", "truyen-ngan-ngon-tinh" },
                {"Truyên Teen - Tuổi Học Trò", "truyen-teen-tuoi-hoc-tro" },
                {"Truyện Tranh", "truyen-tranh" },
                {"Tử Vi - Phong Thủy", "tu-vi-phong-thuy" },
                {"Văn Hóa - Tôn Giáo", "van-hoa-ton-giao" },
                {"Văn Học Việt Nam", "van-hoc-viet-nam" },
                {"Y Học - Sức Khỏe", "y-hoc-suc-khoe" }
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

        public bool CheckLogin(CommonResource.User user)
        {
            using (var md5 = MD5.Create())
            {
                var ePassword = md5.ComputeHash(Encoding.ASCII.GetBytes(user.Password));
                return sqlManager.CheckUserLogin(user.UserName, ePassword);
            }
        }
    }
}
