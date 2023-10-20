CREATE DATABASE QUANLYNHAHANGVKAT
GO

USE QUANLYNHAHANGVKAT
GO
CREATE TABLE TableFood(
	id int IDENTITY(1,1) PRIMARY KEY , 
	name NVARCHAR(100) NOT NULL,
	status NVARCHAR(100) NOT NULL,   -- 1 :trống || 0 :có người
)
GO
CREATE TABLE Account(
	Username nvarchar(100) PRIMARY KEY NOT NULL,
	Displayname nvarchar(100) NOT NULL default N'VKAT',
	Password nvarchar(100) NOT NULL,
	Type int NOT NULL default 1,			-- 0: Admin || 1: Staff
)
GO

CREATE TABLE FoodCategory(
	id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(100) NULL,
)
GO
CREATE TABLE Food(
	id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(100) NOT NULL,
	idCategory int NOT NULL,
	price float NOT NULL,

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO
CREATE TABLE Bill(
	id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	DateCheckIn date NOT NULL default getdate(),
	DateCheckOut date NULL,
	idTable int NOT NULL,
	status int NOT NULL,        -- 1 : đã thanh toán || 0 : chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO
ALTER TABLE dbo.Bill ADD discount INT 
GO
UPDATE dbo.Bill SET discount = 0
GO
ALTER TABLE dbo.Bill ADD totalPrice float
GO

CREATE TABLE BillInfor(
	id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	idBill int NOT NULL,
	idFood int NOT NULL,
	count int NOT NULL default 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id) ,
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
-- Nhập dữ liệu
INSERT INTO Account(UserName, DisplayName, Password, Type) VALUES (N'chivy', N'VKAT', N'0', 0)
INSERT INTO Account(UserName, DisplayName, Password, Type) VALUES (N'thang', N'VKAT', N'1', 1)
INSERT INTO Account(UserName, DisplayName, Password, Type) VALUES (N'khai', N'VKAT', N'0', 0)
INSERT INTO Account(UserName, DisplayName, Password, Type) VALUES (N'ngocanh', N'VKAT', N'1', 1)
INSERT INTO Account(UserName, DisplayName, Password, Type) VALUES (N'staff', N'VKAT', N'1', 1)
GO

SET IDENTITY_INSERT TableFood ON
INSERT INTO TableFood(id , name , status) VALUES (1, N'Bàn 1', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (2, N'Bàn 2', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (3, N'Bàn 3', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (4, N'Bàn 4', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (5, N'Bàn 5', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (6, N'Bàn 6', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (7, N'Bàn 7', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (8, N'Bàn 8', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (9, N'Bàn 9', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (10, N'Bàn 10', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (11, N'Bàn 11', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (12, N'Bàn 12', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (13, N'Bàn 13', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (14, N'Bàn 14', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (15, N'Bàn 15', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (16, N'Bàn 16', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (17, N'Bàn 17', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (18, N'Bàn 18', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (19, N'Bàn 19', N'Trống')
INSERT INTO TableFood(id , name , status) VALUES (20, N'Bàn 20', N'Trống')
SET IDENTITY_INSERT TableFood OFF
GO

SET IDENTITY_INSERT FoodCategory ON
INSERT INTO FoodCategory(id , name ) VALUES (1, N'Khai vị')
INSERT INTO FoodCategory(id , name ) VALUES (2, N'Hấp xào')
INSERT INTO FoodCategory(id , name ) VALUES (3, N'Nướng')
INSERT INTO FoodCategory(id , name ) VALUES (4, N'Chiên')
INSERT INTO FoodCategory(id , name ) VALUES (5, N'Tráng miệng')
INSERT INTO FoodCategory(id , name ) VALUES (6, N'Nước')
INSERT INTO FoodCategory(id , name ) VALUES (7, N'Lẩu')
SET IDENTITY_INSERT FoodCategory OFF
GO

SET IDENTITY_INSERT Food ON 
INSERT INTO Food (id, name, idCategory, price) VALUES (1, N'Salad rau trộn', 1, 60000)
INSERT INTO Food (id, name, idCategory, price) VALUES (2, N'Nộm ngó sen tôm thịt', 1, 100000)
INSERT INTO Food (id, name, idCategory, price) VALUES (3, N'Dê núi hấp xả', 2, 150000)
INSERT INTO Food (id, name, idCategory, price) VALUES (4, N'Mực trứng hấp bia', 2, 170000)
INSERT INTO Food (id, name, idCategory, price) VALUES (5, N'Dê núi nướng tảng', 3, 200000)
INSERT INTO Food (id, name, idCategory, price) VALUES (6, N'Tôm nướng mọi', 3, 180000)
INSERT INTO Food (id, name, idCategory, price) VALUES (7, N'Cơm chiên hải sản', 4, 80000)
INSERT INTO Food (id, name, idCategory, price) VALUES (8, N'Bò chiên cốm', 4, 180000)
INSERT INTO Food (id, name, idCategory, price) VALUES (9, N'Trái cây dĩa theo mùa', 5, 80000)
INSERT INTO Food (id, name, idCategory, price) VALUES (10, N'Bia Saigon', 6, 17000)
INSERT INTO Food (id, name, idCategory, price) VALUES (11, N'Nước ngọt(các loại)', 6, 15000)
INSERT INTO Food (id, name, idCategory, price) VALUES (12, N'Lẩu hải sản', 7, 300000)
INSERT INTO Food (id, name, idCategory, price) VALUES (13, N'Lẩu bò', 7, 250000)
SET IDENTITY_INSERT Food OFF
GO

----------------------TEST----------------

-- Đăng nhập
CREATE PROC USP_LOGIN
@userName nvarchar(100) , @passWord nvarchar (100)
AS
BEGIN
	SELECT* FROM dbo.Account 
	WHERE Username = @userName AND Password = @passWord
END
GO

--Danh sách bàn
CREATE PROC USP_TABLELIST
AS	SELECT* FROM dbo.TableFood
GO

--Hiện thị bill
SELECT f.name , bi.count , f.price , f.price*bi.count AS TotalPrice 
FROM BillInfor bi , Bill b , Food f
WHERE bi.idBill = b.id and bi.idFood = f.id and b.idTable = 2

-- Them bill
CREATE PROC USP_InsertBill 
@idTable INT
AS
BEGIN
	INSERT INTO Bill ( DateCheckIn, DateCheckOut, idTable, status , discount) VALUES ( GETDATE() , -- DateCheckIn 
																			NULL , --DateCheckOut
																			@idTable , 
																			0,
																			0 ) 
END 
GO
--Them billinfo
CREATE PROC USP_InsertBillInfo
@idBill INT , @idFood INT , @count INT
AS
BEGIN
	DECLARE @isExitBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExitBillInfo = ID , @foodCount = COUNT FROM dbo.BillInfor
													WHERE idBill = @idBill AND idFood = @idFood

	IF(@isExitBillInfo > 0) -- KTRA TON TAI BILL HAY CHUA , CO ROI THI UPDATE
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0 )
			UPDATE dbo.BillInfor SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfor WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT INTO BillInfor( idBill, idFood, count) VALUES ( @idBill , @idFood , @count ) 
	END


END
GO
--Trigger update billInfo
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfor FOR INSERT , UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM inserted
	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0		--Status = 0 là có người

	UPDATE dbo.TableFood SET status =N'Có người' WHERE id = @idTable
END
GO
-----------------------
CREATE TRIGGER UTG_UpdateCheckout
ON dbo.Bill FOR UPDATE -- cho update
AS
BEGIN
	DECLARE @idbill INT
	SELECT @idbill = id FROM Inserted
	DECLARE @idtable INT
	SELECT @idtable =idTable FROM dbo.Bill WHERE id=@idbill AND status=1 --Bàn nào checkout , chuyển bàn sẽ trống
	UPDATE dbo.Tablefood SET status =N'Trống' WHERE id=@idtable
END
GO
---------------------
CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR INSERT -- cho thêm
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM inserted
	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	IF(@count = 0 )		--Không có bill nào sẽ set trống
		UPDATE dbo.TableFood SET status =N'Trống' WHERE id = @idTable

END
GO

-- Trigger delete billinfo
CREATE TRIGGER UTG_DeleteBillInfo
ON BillInfor FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id , @idBill = deleted.idBill FROM deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM BillInfor Bi , Bill B 
	WHERE B.id = Bi.idBill AND B.id = @idBill AND B.status = 0
	IF(@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable

END
GO
--- Chuyển bàn
CREATE PROC USP_SwitchTabel
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfor WHERE idBill = @idFirstBill
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfor WHERE idBill = @idSeconrdBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfor WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfor SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfor SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

-- Lấy doanh thu
CREATE PROC USP_GetDoanhThu
@checkin Date , @checkout Date
AS
BEGIN
	SELECT  T.name AS [Tên bàn] , DateCheckIn AS [Ngày vào] , DateCheckOut AS [Ngày ra] , discount AS [Giảm giá] , B.totalPrice AS [Tổng tiền]
	FROM Bill B , TableFood T
	WHERE DateCheckIn >= @checkin AND DateCheckOut <= @checkout AND B.status =1 AND T.id = B.idTable
END
GO
--Tổng doanh thu
CREATE PROC USP_TongDoanhThu
@checkin Date , @checkout Date
AS
BEGIN
	SELECT SUM(B.totalPrice) 
	FROM Bill B , TableFood T
	WHERE DateCheckIn >= @checkin AND DateCheckOut <= @checkout AND B.status =1 AND T.id = B.idTable
END
GO
-- Cập nhật tài khoản
CREATE PROC USP_UpdateAccount
@username NVARCHAR(100) , @displayname NVARCHAR(100) , @password NVARCHAR(100) , @newpassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0  --K
	SELECT @isRightPass = COUNT(*) FROM Account WHERE Username = @username AND Password = @password

	IF(@isRightPass = 1)
	BEGIN
		IF(@newpassword = NULL OR @newpassword = '')
		BEGIN
			UPDATE Account SET Displayname = @displayname WHERE Username = @username
		END
		ELSE 
			UPDATE Account SET Displayname = @displayname , Password = @newpassword WHERE Username = @username
	END
END
GO
--Tìm thức ăn không cần dấu
-- Tạo một hàm tự định nghĩa để chuyển đổi chuỗi có dấu thành chuỗi không dấu
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
