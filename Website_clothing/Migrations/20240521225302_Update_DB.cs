using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Website_clothing.Migrations
{
    /// <inheritdoc />
    public partial class Update_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chatlieus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatlieus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucSanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Ten = table.Column<string>(type: "varchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucSanPhams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GiamGias",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GiaTri = table.Column<double>(type: "float", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiamGias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hangs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KichCos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "mauSacs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSacs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuyDoiDiems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiLeTichDiem = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDoiDiems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DieuKien = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GiaTri = table.Column<double>(type: "float", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "varchar(500)", nullable: false),
                    trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDDanhMucSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(max)", nullable: false),
                    Anh = table.Column<string>(type: "varchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPhams_DanhMucSanPhams_ID",
                        column: x => x.ID,
                        principalTable: "DanhMucSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    SDT = table.Column<string>(type: "char(15)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Diem = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KhachHangs_GioHangs_ID",
                        column: x => x.ID,
                        principalTable: "GioHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SDT = table.Column<string>(type: "varchar(15)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanViens_Roles_IDRole",
                        column: x => x.IDRole,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CtSanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDDanhGia = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ma = table.Column<string>(type: "varchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtSanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_GiamGias_IDGiamGia",
                        column: x => x.IDGiamGia,
                        principalTable: "GiamGias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_Hangs_IDHang",
                        column: x => x.IDHang,
                        principalTable: "Hangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_SanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_chatlieus_IDChatLieu",
                        column: x => x.IDChatLieu,
                        principalTable: "chatlieus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoadons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCTHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(max)", nullable: false),
                    TienShip = table.Column<double>(type: "float", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenNgNhan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SDT = table.Column<string>(type: "char(15)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PTThanhToan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hoadons_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoadons_NhanViens_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTGioHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GioHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCTSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTGioHangs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CTGioHangs_CtSanPhams_IdCTSanPham",
                        column: x => x.IdCTSanPham,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CTGioHangs_GioHangs_GioHangID",
                        column: x => x.GioHangID,
                        principalTable: "GioHangs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhamKichCo",
                columns: table => new
                {
                    cTSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    kichCosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhamKichCo", x => new { x.cTSanPhamsID, x.kichCosID });
                    table.ForeignKey(
                        name: "FK_CTSanPhamKichCo_CtSanPhams_cTSanPhamsID",
                        column: x => x.cTSanPhamsID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhamKichCo_KichCos_kichCosID",
                        column: x => x.kichCosID,
                        principalTable: "KichCos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhamMauSac",
                columns: table => new
                {
                    MauSacsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cTSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhamMauSac", x => new { x.MauSacsID, x.cTSanPhamsID });
                    table.ForeignKey(
                        name: "FK_CTSanPhamMauSac_CtSanPhams_cTSanPhamsID",
                        column: x => x.cTSanPhamsID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhamMauSac_mauSacs_MauSacsID",
                        column: x => x.MauSacsID,
                        principalTable: "mauSacs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhamVoucher",
                columns: table => new
                {
                    CTSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vouchersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhamVoucher", x => new { x.CTSanPhamsID, x.vouchersID });
                    table.ForeignKey(
                        name: "FK_CTSanPhamVoucher_CtSanPhams_CTSanPhamsID",
                        column: x => x.CTSanPhamsID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhamVoucher_vouchers_vouchersID",
                        column: x => x.vouchersID,
                        principalTable: "vouchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGias",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Sao = table.Column<int>(type: "int", nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DanhGias_CtSanPhams_ID",
                        column: x => x.ID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CtHoadons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtHoadons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CtHoadons_hoadons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doiTras",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    NgayDoiTra = table.Column<DateTime>(type: "datetime", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HanDoi = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doiTras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_doiTras_SanPhams_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doiTras_hoadons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonVoucher",
                columns: table => new
                {
                    HoaDonsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VouchersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonVoucher", x => new { x.HoaDonsID, x.VouchersID });
                    table.ForeignKey(
                        name: "FK_HoaDonVoucher_hoadons_HoaDonsID",
                        column: x => x.HoaDonsID,
                        principalTable: "hoadons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonVoucher_vouchers_VouchersID",
                        column: x => x.VouchersID,
                        principalTable: "vouchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lichSuMuaHangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichSuMuaHangs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_lichSuMuaHangs_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_lichSuMuaHangs_hoadons_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "LichSuTichDiems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDQuyDoiDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(15)", nullable: false),
                    Diem = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuTichDiems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LichSuTichDiems_KhachHangs_IDKhachHang",
                        column: x => x.IDKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichSuTichDiems_QuyDoiDiems_IDQuyDoiDiem",
                        column: x => x.IDQuyDoiDiem,
                        principalTable: "QuyDoiDiems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichSuTichDiems_hoadons_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_GioHangID",
                table: "CTGioHangs",
                column: "GioHangID");

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_IdCTSanPham",
                table: "CTGioHangs",
                column: "IdCTSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_CtHoadons_IdHoaDon",
                table: "CtHoadons",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhamKichCo_kichCosID",
                table: "CTSanPhamKichCo",
                column: "kichCosID");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhamMauSac_cTSanPhamsID",
                table: "CTSanPhamMauSac",
                column: "cTSanPhamsID");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDChatLieu",
                table: "CtSanPhams",
                column: "IDChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDGiamGia",
                table: "CtSanPhams",
                column: "IDGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDHang",
                table: "CtSanPhams",
                column: "IDHang");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDSanPham",
                table: "CtSanPhams",
                column: "IDSanPham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhamVoucher_vouchersID",
                table: "CTSanPhamVoucher",
                column: "vouchersID");

            migrationBuilder.CreateIndex(
                name: "IX_doiTras_IdHoaDon",
                table: "doiTras",
                column: "IdHoaDon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_doiTras_IdSanPham",
                table: "doiTras",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoadons_IDKhachHang",
                table: "hoadons",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoadons_IDNhanVien",
                table: "hoadons",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonVoucher_VouchersID",
                table: "HoaDonVoucher",
                column: "VouchersID");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuMuaHangs_IDHoaDon",
                table: "lichSuMuaHangs",
                column: "IDHoaDon",
                unique: true,
                filter: "[IDHoaDon] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuMuaHangs_IDKhachHang",
                table: "lichSuMuaHangs",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTichDiems_IDHoaDon",
                table: "LichSuTichDiems",
                column: "IDHoaDon",
                unique: true,
                filter: "[IDHoaDon] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTichDiems_IDKhachHang",
                table: "LichSuTichDiems",
                column: "IDKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTichDiems_IDQuyDoiDiem",
                table: "LichSuTichDiems",
                column: "IDQuyDoiDiem");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IDRole",
                table: "NhanViens",
                column: "IDRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTGioHangs");

            migrationBuilder.DropTable(
                name: "CtHoadons");

            migrationBuilder.DropTable(
                name: "CTSanPhamKichCo");

            migrationBuilder.DropTable(
                name: "CTSanPhamMauSac");

            migrationBuilder.DropTable(
                name: "CTSanPhamVoucher");

            migrationBuilder.DropTable(
                name: "DanhGias");

            migrationBuilder.DropTable(
                name: "doiTras");

            migrationBuilder.DropTable(
                name: "HoaDonVoucher");

            migrationBuilder.DropTable(
                name: "lichSuMuaHangs");

            migrationBuilder.DropTable(
                name: "LichSuTichDiems");

            migrationBuilder.DropTable(
                name: "KichCos");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "CtSanPhams");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "QuyDoiDiems");

            migrationBuilder.DropTable(
                name: "hoadons");

            migrationBuilder.DropTable(
                name: "GiamGias");

            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "chatlieus");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "DanhMucSanPhams");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
