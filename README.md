# Chương trình thư viện online đơn giản sử dụng ngôn ngữ lập trình C# (winform với .NET framework)
# Cách hoạt động
Sử dụng thư viện hỗ trợ lập trình Socket của .NET. Client và server giao tiếp với nhau thông quan các socket
# Thiết lập kết nối 
Đầu tiên, thiết lập server với 1 IP và port cố định (bind nó cho socket của server). Đồng thời tiến hành tiếp nhận connect từ client (giới hạn số lượng connect qua hàm Socket.Listen(n: số lượng tối đa). Hàm tiếp nhận kết nối sẽ chạy thành một luồng riêng. Hàm này sẽ gọi lại một hàm callback thông qua đối số AsysnFunction khi nhận kết nối từ một client bất kì. Hàm được gọi lại sẽ tiến hành gọi hàm tiếp nhận kết nối (đệ quy) để tiếp tục nhận kết nối từ một socket khác.
# Truyền gửi dữ liệu
Sau khi 
