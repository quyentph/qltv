create database quanlithuvien_nhom2
GO
use quanlithuvien_nhom2
GO
--TaiKhoan
create table TaiKhoan(
	Username varchar(100) primary key,
	Pass varchar(100) not null,
)
GO
--Thu thu
create table ThuThu(
	ID_TT int identity(0,1) primary key,
	TenThuThu nvarchar(100) not null
)
GO
--Loai sach
create table LoaiSach(
	ID_LS int identity(0,1) primary key,
	TenLS nvarchar(100) not null, --Trinh tham, kinh di, ...
)
GO
--Tac gia
create table TacGia(
	ID_TG int identity(0,1) primary key,
	TenTG nvarchar(100) not null,
)
GO
--Sach
create table Sach(
	ID_Sach int identity(0,1) primary key,
	TenSach nvarchar(100) not null,
	SoLuongSach int not null --So luong sach co san
)
GO
--The loai sach
create table TheLoaiSach(
	ID_Sach int references Sach(ID_Sach) not null,
	ID_LS int references LoaiSach(ID_LS) not null, 
	primary key(ID_Sach,ID_LS)
)
GO
--Chi tiet cac tac gia cua sach / dong tac gia
create table DongTacGia(
	ID_Sach int references Sach(ID_Sach) not null,
	ID_TG int references TacGia(ID_TG) not null,
	primary key(ID_Sach,ID_TG)
)
GO
--Doc Gia
create table DocGia(
	ID_DG int identity(0,1) primary key,
	TenDG nvarchar(100) not null,
	SDT char(10) not null,
	CCCD char(12) unique not null,
)
GO
--Phieu muon
create table PhieuMuon(
	ID_PM int identity(0,1) primary key ,
	ID_DG int references DocGia(ID_DG) not null,
	ID_TT int references ThuThu(ID_TT) not null,
	NgayMuon date not null,
	HanTra date not null,
	TrangThai bit not null,  -- 0: chua tra / 1: da tra
)
GO
--Phieu tra muon
create table PhieuTraMuon(
	ID_PTM int identity(0,1) primary key,
	ID_TT int references ThuThu(ID_TT),
	ID_DG int references DocGia(ID_DG),
	ID_PM int references PhieuMuon(ID_PM) unique,
	NgayTra date not null,
	SoNgayTraMuon int not null,
	TienPhat money not null,
)
GO
--Chi Tiet Phieu Muon
create table ChiTietPhieuMuon(
	ID_PM int references PhieuMuon(ID_PM),
	ID_Sach int references Sach(ID_Sach),
	primary key (ID_PM,ID_Sach),
)
GO
CREATE VIEW TomLuocSach
AS
SELECT ID_SACH AS [Mã sách],
    TenSach AS [Tên sách],
    (SELECT STRING_AGG(LS.TenLS, ', ')
        FROM TheLoaiSach AS TLS
	    INNER JOIN LoaiSach AS LS
	    ON TLS.ID_LS = LS.ID_LS
        WHERE TLS.ID_Sach = Sach.ID_Sach) AS [Thể loại],
    (SELECT STRING_AGG(TG.TenTG, ', ')
        FROM DongTacGia AS DTG
	    INNER JOIN TacGia AS TG
	    ON DTG.ID_TG = TG.ID_TG
        WHERE DTG.ID_Sach = Sach.ID_Sach) AS [Tác giả],
	SoLuongSach AS [Số lượng]
FROM Sach;
GO
CREATE VIEW TomLuocPhieuMuon
AS
SELECT PM.ID_PM, PM.ID_DG, DG.TenDG AS [Độc giả], COUNT(*) AS [Số sách mượn], PM.NgayMuon AS [Ngày mượn], PM.HanTra AS [Hạn trả], PM.TrangThai AS [Đã trả], PM.ID_TT, TT.TenThuThu AS [Thủ thư]
FROM PhieuMuon AS PM
INNER JOIN DocGia AS DG
ON PM.ID_DG = DG.ID_DG
INNER JOIN ThuThu AS TT
ON TT.ID_TT = PM.ID_TT
INNER JOIN ChiTietPhieuMuon AS CTPM
ON CTPM.ID_PM = PM.ID_PM
INNER JOIN Sach
ON Sach.ID_Sach = CTPM.ID_Sach
GROUP BY PM.ID_PM, PM.ID_DG, PM.ID_TT, DG.TenDG, TT.TenThuThu, PM.NgayMuon, PM.HanTra, PM.TrangThai;
GO
CREATE PROCEDURE SP_ChiTietPhieuMuon_ThayDoiSLSach (
	@MaPhieuMuon int,
	@ThayDoiSLSach int
)
AS
UPDATE Sach
	SET SoLuongSach = SoLuongSach + @ThayDoiSLSach
	FROM Sach
	INNER JOIN ChiTietPhieuMuon AS CTPM
	ON CTPM.ID_Sach = Sach.ID_Sach
	WHERE CTPM.ID_PM = @MaPhieuMuon;
GO
create view view_LatePaid
as
	select 
		   ThuThu.TenThuThu,
		   DocGia.TenDG, 
		   DocGia.SDT,
		   PhieuTraMuon.NgayTra,
		   count(ChiTietPhieuMuon.ID_Sach) as SoSachDaMuon,
		   datediff(day,PhieuMuon.HanTra, PhieuTraMuon.NgayTra) as SoNgayTraMuon,
		   PhieuTraMuon.TienPhat,
		   PhieuTraMuon.ID_PTM,
		   ThuThu.ID_TT,
		   PhieuMuon.HanTra,
		   PhieuTraMuon.ID_PM
	from DocGia
	inner join PhieuMuon on DocGia.ID_DG = PhieuMuon.ID_DG
	inner join ChiTietPhieuMuon on PhieuMuon.ID_PM = ChiTietPhieuMuon.ID_PM
	inner join PhieuTraMuon on PhieuMuon.ID_PM = PhieuTraMuon.ID_PM
	inner join ThuThu on PhieuTraMuon.ID_TT = ThuThu.ID_TT
	where PhieuTraMuon.NgayTra > PhieuMuon.HanTra and PhieuMuon.TrangThai=1
	group by 
		   PhieuTraMuon.ID_PM,
		   ThuThu.TenThuThu,
		   DocGia.TenDG, 
		   DocGia.SDT,
		   PhieuMuon.HanTra,
		   PhieuTraMuon.TienPhat,
		   PhieuTraMuon.ID_PTM,
		   PhieuTraMuon.NgayTra,
		   ThuThu.ID_TT
GO
CREATE PROCEDURE Fine_Update 
AS
BEGIN
    -- Cập nhật tiền phạt cho mỗi phiếu trả muộn
    UPDATE PhieuTraMuon
    SET TienPhat = CASE
        WHEN DATEDIFF(DAY, PhieuMuon.HanTra, PhieuTraMuon.NgayTra) <= 30
            THEN DATEDIFF(DAY, PhieuMuon.HanTra, PhieuTraMuon.NgayTra) * 5000 
			ELSE 30 * 5000 + (DATEDIFF(DAY, PhieuMuon.HanTra, PhieuTraMuon.NgayTra) - 30) * 10000
    END
    FROM PhieuTraMuon
    INNER JOIN PhieuMuon ON PhieuTraMuon.ID_PM = PhieuMuon.ID_PM
    WHERE PhieuTraMuon.NgayTra > PhieuMuon.HanTra;
END;
go
create procedure cbBox_Book
	@ID_PM int
as
	begin
		select Sach.TenSach
		from Sach
		inner join ChiTietPhieuMuon on ChiTietPhieuMuon.ID_Sach = Sach.ID_Sach
		inner join PhieuMuon on ChiTietPhieuMuon.ID_PM =PhieuMuon.ID_PM 
		inner join DocGia on PhieuMuon.ID_DG = DocGia.ID_DG
		where PhieuMuon.ID_PM = @ID_PM
	end;
go
CREATE FUNCTION Borrow_book(@ID_PM INT)
RETURNS TABLE
AS
RETURN (
    SELECT 
        Sach.ID_Sach,
        Sach.TenSach,
        -- Lấy danh sách thể loại sách
        (
            SELECT STRING_AGG(LS.TenLS, ', ')
            FROM TheLoaiSach AS TLS
            INNER JOIN LoaiSach AS LS
                ON TLS.ID_LS = LS.ID_LS
            WHERE TLS.ID_Sach = Sach.ID_Sach
        ) AS TheLoai,
        -- Lấy danh sách tác giả
        (
            SELECT STRING_AGG(TG.TenTG, ', ')
            FROM DongTacGia AS DTG
            INNER JOIN TacGia AS TG
                ON DTG.ID_TG = TG.ID_TG
            WHERE DTG.ID_Sach = Sach.ID_Sach
        ) AS TacGia
    FROM 
        Sach
    INNER JOIN ChiTietPhieuMuon ON Sach.ID_Sach = ChiTietPhieuMuon.ID_Sach
    INNER JOIN PhieuMuon ON ChiTietPhieuMuon.ID_PM = PhieuMuon.ID_PM
    WHERE 
        PhieuMuon.ID_PM = @ID_PM
);
go
CREATE FUNCTION make_a_latepaid(@ID_PM int,@NgayTra DATE)
RETURNS TABLE
AS
RETURN (
    SELECT DISTINCT
        @ID_PM AS Ma, 
		PhieuMuon.ID_DG AS ID_DG,
		DocGia.TenDG AS TenDG,
        COUNT(ChiTietPhieuMuon.ID_Sach) AS SoSachDaMuon,
		PhieuMuon.HanTra as HanTra,
        DATEDIFF(DAY, PhieuMuon.HanTra, @NgayTra) AS SoNgayTraMuon,
        CASE
            WHEN DATEDIFF(DAY, PhieuMuon.HanTra, @NgayTra) <= 30
                THEN DATEDIFF(DAY, PhieuMuon.HanTra, @NgayTra) * 5000 
            ELSE 30 * 5000 + (DATEDIFF(DAY, PhieuMuon.HanTra, @NgayTra) - 30) * 10000
        END AS TienPhat
    FROM PhieuMuon
    INNER JOIN ChiTietPhieuMuon ON PhieuMuon.ID_PM = ChiTietPhieuMuon.ID_PM
	INNER JOIN DocGia on PhieuMuon.ID_DG = DocGia.ID_DG
	WHERE PhieuMuon.ID_PM = @ID_PM
    GROUP BY PhieuMuon.ID_PM, PhieuMuon.HanTra,PhieuMuon.ID_DG,DocGia.TenDG
);
go
CREATE PROCEDURE GetBooks
AS
BEGIN
    SELECT 
        TacGia.ID_TG AS ID,
        TacGia.TenTG AS TENTG,
        -- Sử dụng SUBSTRING và LEN để loại bỏ dấu phẩy thừa
        SUBSTRING(
            (
                SELECT DISTINCT S.TenSach + ', '
                FROM Sach S
                INNER JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                WHERE DTG.ID_TG = TacGia.ID_TG
                FOR XML PATH(''), TYPE
            ).value('(/)[1]', 'NVARCHAR(MAX)'),
            1,
            LEN(
                (
                    SELECT DISTINCT S.TenSach + ', '
                    FROM Sach S
                    INNER JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                    WHERE DTG.ID_TG = TacGia.ID_TG
                    FOR XML PATH(''), TYPE
                ).value('(/)[1]', 'NVARCHAR(MAX)')
            ) - 1
        ) AS TENSACH,
        SUBSTRING(
            (
                SELECT DISTINCT LS.TenLS + ', '
                FROM LoaiSach LS
                INNER JOIN TheLoaiSach TLS ON LS.ID_LS = TLS.ID_LS
                INNER JOIN Sach S ON TLS.ID_Sach = S.ID_Sach
                INNER JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                WHERE DTG.ID_TG = TacGia.ID_TG
                FOR XML PATH(''), TYPE
            ).value('(/)[1]', 'NVARCHAR(MAX)'),
            1,
            LEN(
                (
                    SELECT DISTINCT LS.TenLS + ', '
                    FROM LoaiSach LS
                    INNER JOIN TheLoaiSach TLS ON LS.ID_LS = TLS.ID_LS
                    INNER JOIN Sach S ON TLS.ID_Sach = S.ID_Sach
                    INNER JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                    WHERE DTG.ID_TG = TacGia.ID_TG
                    FOR XML PATH(''), TYPE
                ).value('(/)[1]', 'NVARCHAR(MAX)')
            ) - 1
        ) AS THELOAI
    FROM TacGia
    INNER JOIN DongTacGia ON TacGia.ID_TG = DongTacGia.ID_TG
    GROUP BY TacGia.ID_TG, TacGia.TenTG;
END
go
CREATE PROCEDURE GetBooks2
AS
BEGIN
    SELECT 
        TacGia.ID_TG AS ID,
        TacGia.TenTG AS TENTG,
        -- Sử dụng SUBSTRING và LEN để loại bỏ dấu phẩy thừa
        SUBSTRING(
            (
                SELECT DISTINCT S.TenSach + ', '
                FROM Sach S
                LEFT JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                WHERE DTG.ID_TG = TacGia.ID_TG
                FOR XML PATH(''), TYPE
            ).value('(/)[1]', 'NVARCHAR(MAX)'),
            1,
            LEN(
                (
                    SELECT DISTINCT S.TenSach + ', '
                    FROM Sach S
                    LEFT JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                    WHERE DTG.ID_TG = TacGia.ID_TG
                    FOR XML PATH(''), TYPE
                ).value('(/)[1]', 'NVARCHAR(MAX)')
            ) - 1
        ) AS TENSACH,
        SUBSTRING(
            (
                SELECT DISTINCT LS.TenLS + ', '
                FROM LoaiSach LS
                LEFT JOIN TheLoaiSach TLS ON LS.ID_LS = TLS.ID_LS
                LEFT JOIN Sach S ON TLS.ID_Sach = S.ID_Sach
                LEFT JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                WHERE DTG.ID_TG = TacGia.ID_TG
                FOR XML PATH(''), TYPE
            ).value('(/)[1]', 'NVARCHAR(MAX)'),
            1,
            LEN(
                (
                    SELECT DISTINCT LS.TenLS + ', '
                    FROM LoaiSach LS
                    LEFT JOIN TheLoaiSach TLS ON LS.ID_LS = TLS.ID_LS
                    LEFT JOIN Sach S ON TLS.ID_Sach = S.ID_Sach
                    LEFT JOIN DongTacGia DTG ON S.ID_Sach = DTG.ID_Sach
                    WHERE DTG.ID_TG = TacGia.ID_TG
                    FOR XML PATH(''), TYPE
                ).value('(/)[1]', 'NVARCHAR(MAX)')
            ) - 1
        ) AS THELOAI
    FROM TacGia
    LEFT JOIN DongTacGia ON TacGia.ID_TG = DongTacGia.ID_TG
    GROUP BY TacGia.ID_TG, TacGia.TenTG;
END
GO
CREATE VIEW SachChuan AS
SELECT 
    S.ID_Sach AS [Mã sách],
    S.TenSach AS [Tên sách],
    (SELECT STRING_AGG(TG.ID_TG, ', ')
     FROM DongTacGia DTG
     INNER JOIN TacGia TG ON DTG.ID_TG = TG.ID_TG
     WHERE DTG.ID_Sach = S.ID_Sach) AS [Mã tác giả],
    (SELECT STRING_AGG(TG.TenTG, ', ')
     FROM DongTacGia DTG
     INNER JOIN TacGia TG ON DTG.ID_TG = TG.ID_TG
     WHERE DTG.ID_Sach = S.ID_Sach) AS [Tên tác giả],
    (SELECT STRING_AGG(LS.ID_LS, ', ')
     FROM TheLoaiSach TLS
     INNER JOIN LoaiSach LS ON TLS.ID_LS = LS.ID_LS
     WHERE TLS.ID_Sach = S.ID_Sach) AS [Mã loại sách],
    (SELECT STRING_AGG(LS.TenLS, ', ')
     FROM TheLoaiSach TLS
     INNER JOIN LoaiSach LS ON TLS.ID_LS = LS.ID_LS
     WHERE TLS.ID_Sach = S.ID_Sach) AS [Loại sách],
    S.SoLuongSach AS [Số lượng sách]
FROM Sach S;
GO
CREATE PROCEDURE DeleteBook
    @TenSach NVARCHAR(100)
AS
BEGIN
    DECLARE @ID_Sach INT;

    -- Lấy ID_Sach từ TenSach
    SELECT @ID_Sach = ID_Sach FROM Sach WHERE TenSach = @TenSach;

    IF @ID_Sach IS NULL
    BEGIN
        PRINT 'Sách không tồn tại';
        RETURN;
    END

    -- Xóa thông tin từ các bảng liên quan
    DELETE FROM DongTacGia WHERE ID_Sach = @ID_Sach;
    DELETE FROM TheLoaiSach WHERE ID_Sach = @ID_Sach;

    -- Xóa sách
    DELETE FROM Sach WHERE ID_Sach = @ID_Sach;
END;