# Giới thiệu

## Dự án Restaurant Reservation Backend là hệ thống quản lý đặt bàn nhà hàng được xây dựng bằng ASP.NET Core Web API.
Mục tiêu của dự án là cung cấp một nền tảng backend mạnh mẽ, bảo mật và dễ mở rộng để hỗ trợ các ứng dụng frontend (web hoặc mobile) trong việc:

- Quản lý đặt bàn của khách hàng.

- Quản lý thông tin khách hàng và nhân viên.

- Quản lý thực đơn và dịch vụ.

- Xử lý thanh toán và báo cáo cơ bản.

## Công nghệ sử dụng

-.NET 6/7 (ASP.NET Core Web API) – xây dựng RESTful API.

- Entity Framework Core (EF Core) – ORM kết nối cơ sở dữ liệu.

- SQL Server / PostgreSQL – lưu trữ dữ liệu.

- JWT Authentication – xác thực và phân quyền người dùng.

- Swagger / OpenAPI – tài liệu API.

- NuGet Packages – quản lý thư viện.

## Tính năng chính

- Quản lý người dùng: đăng ký, đăng nhập, phân quyền (admin, nhân viên, khách hàng).

- Đặt bàn: khách hàng có thể đặt bàn theo ngày, giờ, số lượng người.

- Quản lý thực đơn: thêm, sửa, xóa món ăn và danh mục.

- Báo cáo: thống kê số lượng đặt bàn, doanh thu cơ bản.

- Bảo mật: đăng nhập với JWT, bảo vệ API endpoint.
