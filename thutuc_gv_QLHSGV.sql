--thu tuc them giao vien
create PROC themGV1
(    
	@MaGV varchar(10),
	@TenGV nvarchar(50),
	@GT nvarchar(50),
	@NgaySinh date,
	@SDT varchar,
	@DiaChi nvarchar(50),
	@Luong int,
	@MaMon varchar(10)
  ) 
AS 
INSERT INTO tblGiaovien(MaGV,TenGV,GT,NgaySinh,SDT,DiaChi,Luong,MaMon) 
VALUES(@MaGV,@TenGV,@GT,@NgaySinh,@SDT,@DiaChi,@Luong,@MaMon)
go

--thu tuc sua, thay doi thong tin giao vien
create PROC suaGV1
(    
	@MaGV varchar(10),
	@TenGV nvarchar(50),
	@GT nvarchar(50),
	@NgaySinh date,
	@SDT varchar,
	@DiaChi nvarchar(50),
	@Luong int,
	@MaMon varchar(10)
  ) 
AS 
UPDATE tblGiaovien
SET TenGV = @TenGV,GT = @GT,NgaySinh =@NgaySinh, SDT = @SDT,DiaChi = @DiaChi, Luong = @Luong, MaMon = @MaMon
WHERE MaGV = @MaGV
go
select *from tblGiaovien
go
update tblGiaovien
set TenGV = N'chinh', GT= N'Nữ', MaMon = 'MH01'
where MaGV = '454'
go 

create proc xoaGV1
( 
     @MaGV char(10) 
) 
AS 
DELETE tblGiaovien 
WHERE MaGV = @MaGV
go