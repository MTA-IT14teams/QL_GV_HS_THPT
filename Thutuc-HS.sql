create proc SP_ThemHS1
(@Ma varchar(50),
@Ten nvarchar(50),
@GT nvarchar(3),
@Ngaysinh date,
@Malop varchar(10),
@Dantoc nvarchar(50),
@Tongiao nvarchar(50),
@Diachi nvarchar(50)
)
as
insert into tblHocSinh(MaHS, TenHS,GT, NgaySinh, MaLop, DanToc, TonGiao, DiaChi)
values (@Ma, @Ten,@GT, @Ngaysinh, @Malop, @Dantoc, @Tongiao, @Diachi)
go

create proc SP_ThayDoi
( @Ma varchar(50),
  @Ten nvarchar(50),
  @GT bit,
@Ngaysinh date,
@Malop varchar(10),
@Dantoc nvarchar(50),
@Tongiao nvarchar(50),
@Diachi nvarchar(50)

)
as
update tblHocSinh
set TenHS=@Ten,
GT=@GT,
   NgaySinh=@Ngaysinh,
   MaLop=@Malop,
   DanToc=@Dantoc,
   TonGiao=@Tongiao,
   DiaChi=@Diachi
   where MaHS=@Ma
go

create proc SP_XoaHS
(@Ma varchar(50)
)
as
Delete tblHocSinh
where MaHS=@Ma
