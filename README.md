# Chương trình thư viện online đơn giản sử dụng ngôn ngữ lập trình C# (winform với .NET framework)
## Cách hoạt động

Sử dụng thư viện hỗ trợ lập trình Socket của .NET [DOC](https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket?view=net-5.0).

Client và server giao tiếp với nhau thông quan các socket.

Mọi thông tin được lưu trữ trong server. Client sẽ request lên server để nhận về thông tin.

Mọi thông tin đều được vận chuyển dưới dạng mảng byte.

## Thiết lập kết nối 

Về Server: Đầu tiên, thiết lập server với 1 IP và port cố định (bind nó cho socket của server). Sau đó đặt socket server trong trạng thái lắng nghe thông qua hàm Socket.Listen(n: số lượng tối đa client có thể kết nối [DOC](https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.listen?view=net-5.0). Đồng thời tiến hành tiếp nhận connect từ client thông qua hàm Socket.BeginAccept [DOC](https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.beginaccept?view=net-5.0), hàm tiếp nhận kết nối sẽ chạy thành một luồng riêng, nó sẽ gọi lại một hàm callback thông qua đối số AsyncCallback (để lấy tham chiếu đến hàm được gọi lại) khi nhận kết nối từ một client bất kì. Hàm được gọi lại sẽ gọi hàm tiếp nhận kết nối (đệ quy) để tiếp tục nhận kết nối từ một socket khác.

Về Client: Khá đơn giản, do server đã được thiết đặt. Client chỉ cần cố gắng connect tới server thông qua hàm Socket.Connect(EndPoint: end point của server bao gồm ip và port) [DOC](https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.connect?view=net-5.0). Ơ đây ta không cần thiết phải gọi BeginConnect (đa luồng) vì hàm này sẽ được gọi lên khi chương trình (phía client) vừa chạy.

## Truyền gửi dữ liệu

Về Server: Sau khi đã nhận 1 connect bất kì sẽ tiến hành gọi hàm Socket.BeginReceive [DOC](https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.socket.beginreceive?view=net-5.0) để nhận những request từ client (Đây là hàm bất đồng bộ được chạy 1 luồng riêng, để không ảnh hưởng tới request của những client khác), hàm này sẽ có callback đến thông qua đối số AsyncCallback (tham chiếu đến hàm callback) sau khi đã nhận được request từ client. Ở hàm callback, ta sẽ kết thúc luồng nhận request qua hàm Socket.EndReceive đồng thời lấy ra và xử lý request của client. 
