create database WebSach
go
use WebSach
go
create table TheLoai
(
maloai int identity primary key,
tenloai nvarchar(30)
)
go
create table Sach
(
masach int identity(1,1) primary key,
maloai int references TheLoai(maloai),
tensach nvarchar(100) not null,
hinh varchar(50),
chuong int,
noidung nvarchar(max),
)
go
---------------------
insert into TheLoai(tenloai) values(N'Hành động')
insert into TheLoai(tenloai) values(N'Phiêu lưu')
insert into TheLoai(tenloai) values(N'Kinh dị')
select * from TheLoai
go
---------------------
insert into Sach(tensach,chuong,hinh,noidung) values(N'Chap 1: Cuộc chiến của A',1,'/Content/images/Book1.jpg',N'Nửa tiếng! Lâm Thiên té trên mặt đất đã nửa tiếng không chút động đậy. Nếu là ở ngoài đường thì hắn đã được người qua đường gọi xe cứu thương đưa tới bệnh viện rồi, nhưng bây giờ lại không có ai gọi cứu thương cho hắn cả. Bên ngoài hành lang phòng ngủ tuy rằng vẫn truyền đến những tiếng ồn ào không ngừng, nhưng trong phòng ngủ của Lâm Thiên ngoại trừ hắn thì không còn ai khác!
“Không phải nằm mơ, xem rat a cũng có một ngày may mắn!” Lâm Thiên mở mắt, bất chấp đầu đang đau nhức do va chạm mạnh với sàn nhà, vội vàng giơ tay trái lên nhìn. Ở ngón giữa có một chiếc nhẫn đang phát ra quang mang màu ngân bạch lóng lánh. Hắn hơi sửng sốt một chút rồi trong lòng lại mừng như điên: “Chiếc nhẫn đã biến hoá rồi! Đã nhận chủ rồi sao?”
Một lúc lâu sau, tâm tình của Lâm Thiên mới có thể dần dần bình ổn lại. Tuy rằng hắn đã xác định tất cả đều chân thật, nhưng hắn vẫn có cảm giác như mình đang nằm mơ!
Lâm Thiên năm nay mười chín tuổi, là một tân sinh của đại học Hải Thiên, tướng mạo bình thường, thuộc loại người ném vào trong một đám người thì không có một chút nổi bật nào. Duy nhất có một điểm nổi bật chính là thời gian hắn thi đại học, đỗ vào trườn đại học quốc gia Hải Thiên – là một trong hai trường đại học trọng điểm của quốc gia. Vốn cuộc đời của hắn có thể cứ như như vậy bình thường mà trôi qua, không có gì đặc sắc. Nhưng ba ngày trước thần xui quỷ khiến thế nào mà hắn bỏ ra mười đồng tệ mua “Đồ gia truyền” của một người, để rồi bây giờ hắn có muốn bình thường cũng không thể bình thường được nữa!
Ba ngày trước, Lâm Thiên đã mua chiếc nhẫn kia, nhưng sau khi về nhà hắn đã đem nó bỏ vào trong ngăn kéo. Chiếc nhẫn đen thui đó mà đeo trên tay thì mất mặt chết. Nếu như không phải hôm nay khi hắn thò tay mò mẫm trong ngăn kéo lung tung để máu dính vào chiếc nhẫn, thì có trời mới biết nó còn bị mai một trong ngăn kéo đến khi nào nữa!
“Vương Hạo, ngươi nói ta nên cám ơn ngươi hay là nên hận ngươi đây?” Lâm Thiên leo lên giường, vừa vuốt ve chiếc nhẫn thì thầm, trong đầu vừa hồi tưởng lại cảnh tượng lúc máu của hắn dính vào chiếc nhẫn.')
insert into Sach(tensach,chuong,hinh,noidung) values(N'Chap 2: Cuộc chiến của A',2,'/Content/images/Book1.jpg',N'Tuy rằng hắn đã xác định tất cả đều chân thật, nhưng hắn vẫn có cảm giác như mình đang nằm mơ!
Lâm Thiên năm nay mười chín tuổi, là một tân sinh của đại học Hải Thiên, tướng mạo bình thường, thuộc loại người ném vào trong một đám người thì không có một chút nổi bật nào. Duy nhất có một điểm nổi bật chính là thời gian hắn thi đại học, đỗ vào trườn đại học quốc gia Hải Thiên – là một trong hai trường đại học trọng điểm của quốc gia. Vốn cuộc đời của hắn có thể cứ như như vậy bình thường mà trôi qua, không có gì đặc sắc. Nhưng ba ngày trước thần xui quỷ khiến thế nào mà hắn bỏ ra mười đồng tệ mua “Đồ gia truyền” của một người, để rồi bây giờ hắn có muốn bình thường cũng không thể bình thường được nữa!
Ba ngày trước, Lâm Thiên đã mua chiếc nhẫn kia, nhưng sau khi về nhà hắn đã đem nó bỏ vào trong ngăn kéo. Chiếc nhẫn đen thui đó mà đeo trên tay thì mất mặt chết. Nếu như không phải hôm nay khi hắn thò tay mò mẫm trong ngăn kéo lung tung để máu dính vào chiếc nhẫn, thì có trời mới biết nó còn bị mai một trong ngăn kéo đến khi nào nữa!
“Vương Hạo, ngươi nói ta nên cám ơn ngươi hay là nên hận ngươi đây?” Lâm Thiên leo lên giường, vừa vuốt ve chiếc nhẫn thì thầm, trong đầu vừa hồi tưởng lại cảnh tượng')
select * from Sach