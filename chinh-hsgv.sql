USE [QL_GV_HS_THPT]
GO
/****** Object:  StoredProcedure [dbo].[themGV1]    Script Date: 06/08/2018 10:36:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[themGV1]
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



USE [QL_GV_HS_THPT]
GO
/****** Object:  StoredProcedure [dbo].[suaGV1]    Script Date: 06/08/2018 10:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[suaGV1]
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

USE [QL_GV_HS_THPT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[XOAGIAOVIEN](@MaGV CHAR(10))
AS
BEGIN
DELETE tblGiaovien
WHERE MaGV = @MaGV
END