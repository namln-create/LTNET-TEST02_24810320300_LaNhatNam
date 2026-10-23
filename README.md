# BÁO CÁO BÀI TẬP THỰC HÀNH LẬP TRÌNH C# WINFORMS

## I. THÔNG TIN SINH VIÊN
* **Họ và tên:** La Nhật Nam
* **Mã số sinh viên:** 24810320300
* **Lớp học phần:** Lập trình .NET - Mã Lớp: D19QTANM1

* **Link Repository:** https://github.com/namln-create/LTNET-TEST02_24810320300_LaNhatNam

---

## II. DANH SÁCH BÀI TẬP HOÀN THÀNH & TỰ ĐÁNH GIÁ

| Bài tập | Tiêu đề bài tập | Trạng thái | Mức độ hoàn thành (%) |
| :--- | :--- | :---: | :---: |
| **Bài 1** | QUẢN LÝ ĐẶT PHÒNG KHÁCH SẠN | Hoàn thành | 100% |
| **Bài 2** | QUẢN LÝ HỒ SƠ NHÂN SỰ & THÔNG TIN LƯƠNG | Hoàn thành | 100% |
| **Bài 3** | HỆ THỐNG MDI QUẢN LÝ TRƯỜNG HỌC & ĐÀO TẠO | Hoàn thành | 100% |
| **Bài 4** | BẢNG ĐIỀU KHIỂN TỔNG HỢP BÁO CÁO KHO HÀNG | Hoàn thành | 100% |
| **Bài 5** | MÔ PHỎNG GIÁM SÁT HỆ THỐNG CẢNH BÁO IOT REAL-TIME | Hoàn thành | 100% |

---

## III. MINH HỌA GIAO DIỆN & KỸ THUẬT NỔI BẬT

### 1. Bài 1: QUẢN LÝ ĐẶT PHÒNG KHÁCH SẠN
* **Kỹ thuật áp dụng:** Cấu hình DataGridView bằng code (`AutoGenerateColumns =
false`), Data Binding 2 chiều với `BindingSource`, Validation với `ErrorProvider`.
* **Hình ảnh minh họa Giao diện:**

![Giao diện chính Bài 1](docs/bai1/main.png)
*Mô tả: Giao diện chính hiển thị.*

![Giao diện chính Bài 1](docs/bai1/result.png)
*Mô tả: Hiển thị DataGridView và đồng bộ dữ liệu 2 chiều lên các
TextBox.*

![Bắt lỗi Validation Bài 1](docs/bai1/error1.png)
*Mô tả: Kiểm tra hợp lệ dữ liệu nhập vào bằng ErrorProvider khi nhấn Thêm mới.*

![Bắt lỗi Validation Bài 1](docs/bai1/error2.png)
*Mô tả: Kiểm tra hợp lệ dữ liệu nhập vào bằng ErrorProvider khi nhấn Thêm mới.*


### 2. Bài 2: QUẢN LÝ HỒ SƠ NHÂN SỰ & THÔNG TIN LƯƠNG
* **Kỹ thuật áp dụng:** `OpenFileDialog` (Tải ảnh bìa), `SaveFileDialog` /
`OpenFileDialog` (Đọc/Ghi file CSV), Cập nhật `StatusStrip` theo thời gian thực.
* **Hình ảnh minh họa Giao diện:**

![Giao diện chính Bài 2](docs/bai2/main.png)
*Mô tả: Giao diện chính hiển thị.*

![Giao diện Load Ảnh](docs/bai2/picture.png)
*Mô tả: Chọn ảnh hiển thị lên PictureBox.*

![Giao diện Load Ảnh](docs/bai2/open.png)
*Mô tả: Mở file csv.*

![Giao diện Load Ảnh](docs/bai2/save.png)
*Mô tả: Lưu file csv.*


---

### 3. Bài 3: HỆ THỐNG QUẢN LÝ TRƯỜNG HỌC (GIAO DIỆN MDI)
- **Kỹ thuật áp dụng:** Giao diện đa cửa sổ (`IsMdiContainer = true`), `MenuStrip` (Thiết lập hệ thống Menu điều hướng), Thuật toán kiểm tra chống mở trùng lặp Form con (`MdiChildren`), Quản lý Layout sắp xếp cửa sổ (Cascade, Tile Vertical/Horizontal).
- **Hình ảnh minh họa Giao diện:**

![Menu Điều hướng](docs/bai3/mdi.png)
*Mô tả: Giao diện chính (Form cha) với hệ thống Menu quản lý các chức năng.*

![Giao diện Sinh viên](docs/bai3/student.png)
*Mô tả: Form con "Danh sách Sinh viên" được gọi và hiển thị lồng gọn gàng bên trong Form cha.*

![Giao diện Môn học](docs/bai3/course.png)
*Mô tả: Form con "Danh mục Môn học" hoạt động song song trên cùng không gian MDI.*


---

### 4. Bài 4: BẢNG ĐIỀU KHIỂN TỔNG HỢP BÁO CÁO KHO HÀNG
- **Kỹ thuật áp dụng:** Xử lý bất đồng bộ với `async`/`await`, chạy luồng ngầm bằng `Task.Run` để tránh đơ giao diện, sử dụng `CancellationTokenSource` để hủy tác vụ đang chạy, và cập nhật `ProgressBar` an toàn từ luồng phụ qua `Invoke`.
- **Hình ảnh minh họa Giao diện:**

![Hoàn thành thống kê](docs/bai4/main.png)
*Mô tả: Giao diện sau khi chạy Task ngầm thành công 100%, hiển thị thông báo hoàn tất mà không làm treo ứng dụng.*

![Hủy tiến trình](docs/bai4/stop.png)
*Mô tả: Minh chứng chức năng hủy tác vụ an toàn bằng CancellationToken khi thanh trình trạng đang chạy dang dở.*

---

### 5. Bài 5: GIÁM SÁT HỆ THỐNG CẢNH BÁO IOT REAL-TIME
- **Kỹ thuật áp dụng:** Xử lý đa luồng (Multi-threading) với vòng lặp vô hạn trong `Task.Run`, cập nhật giao diện an toàn từ luồng phụ bằng `InvokeRequired` và `Invoke`, ngắt tiến trình tức thời bằng `CancellationToken`.
- **Hình ảnh minh họa Giao diện:**

![Đang giám sát](docs/bai5/main.png)
*Mô tả: Hệ thống đang chạy ngầm, liên tục sinh dữ liệu nhiệt độ và đẩy lên DataGridView theo thời gian thực (Thread-Safe).*

![Dừng giám sát](docs/bai5/stop.png)
*Mô tả: Khi nhấn "Dừng Giám sát", luồng ngầm bị hủy an toàn, ngắt kết nối và giữ nguyên lịch sử báo cáo.*

---
