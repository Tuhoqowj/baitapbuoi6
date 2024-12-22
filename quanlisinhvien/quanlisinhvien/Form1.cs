using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlisinhvien.database;

namespace quanlisinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //hàm load các dữ liệu trong toàn bộ form đó
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<Faculty> listFalculty = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFacultyCombobox(listFalculty);
                BlindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // hàm hiển thị cũng như lấy các dữ liệu, giá trị mã khoa
        private void FillFacultyCombobox(List<Faculty> listFacultys)
        {
            this.comboBox1.DataSource = listFacultys;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyID";
        }

        //hàm hiển thị dữ liệu trên datagridview dựa theo database
        private void BlindGrid(List<Student> listStudent)
        {

            foreach (var item in listStudent)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AverageScore;
                dataGridView1.Refresh();
            }
        }

        // code kiểm tra các dong để sửa
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Đưa dữ liệu từ dòng được chọn vào các input
                masv.Text = row.Cells[0].Value?.ToString();
                hoTen.Text = row.Cells[1].Value?.ToString();
                comboBox1.Text = row.Cells[2].Value?.ToString();
                dienTrungBinh.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo context để làm việc với database
                Model1 context = new Model1();

                // Lấy dữ liệu từ các input trên form
                string studentID = masv.Text; // Mã sinh viên
                string fullName = hoTen.Text; // Họ và tên sinh viên
                float averageScore;
                if (!float.TryParse(dienTrungBinh.Text, out averageScore))
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ.");
                    return;
                }
                int facultyID = (int)comboBox1.SelectedValue; // Khoa được chọn từ ComboBox

                // Kiểm tra tính hợp lệ của dữ liệu
                if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Tạo đối tượng sinh viên mới
                Student newStudent = new Student
                {
                    StudentID = studentID,
                    FullName = fullName,
                    AverageScore = averageScore,
                    FacultyID = facultyID
                };

                // Thêm sinh viên vào database
                context.Students.Add(newStudent);

                // Lưu thay đổi vào database
                context.SaveChanges();

                // Hiển thị thông báo thêm thành công
                MessageBox.Show("Thêm sinh viên thành công.");

                // Cập nhật lại DataGridView
                List<Student> listStudent = context.Students.ToList();
                BlindGrid(listStudent);


                // Xóa dữ liệu trên các input sau khi thêm thành công
                masv.Clear();
                hoTen.Clear();
                dienTrungBinh.Clear();
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show(ex.Message);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView hay không
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                    return;
                }

                // Lấy thông tin dòng hiện tại đang được chọn
                int selectedRowIndex = dataGridView1.CurrentRow.Index;

                // Lấy dữ liệu từ các input trên form
                string studentID = masv.Text; // Mã sinh viên
                string fullName = hoTen.Text; // Họ và tên sinh viên
                float averageScore;
                if (!float.TryParse(dienTrungBinh.Text, out averageScore))
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ.");
                    return;
                }
                int facultyID = (int)comboBox1.SelectedValue; // Khoa được chọn từ ComboBox

                // Kiểm tra tính hợp lệ của dữ liệu
                if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Khởi tạo context để làm việc với database
                Model1 context = new Model1();

                // Lấy sinh viên cần sửa trong database dựa trên StudentID
                var studentToUpdate = context.Students.SingleOrDefault(s => s.StudentID == studentID);
                if (studentToUpdate == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại.");
                    return;
                }

                // Cập nhật thông tin sinh viên
                studentToUpdate.FullName = fullName;
                studentToUpdate.AverageScore = averageScore;
                studentToUpdate.FacultyID = facultyID;

                // Lưu thay đổi vào database
                context.SaveChanges();

                // Hiển thị thông báo sửa thành công
                MessageBox.Show("Sửa thông tin sinh viên thành công.");

                // Cập nhật lại DataGridView
                dataGridView1.Rows[selectedRowIndex].Cells[0].Value = studentToUpdate.StudentID;
                dataGridView1.Rows[selectedRowIndex].Cells[1].Value = studentToUpdate.FullName;
                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = context.Faculties
                    .Single(f => f.FacultyID == studentToUpdate.FacultyID).FacultyName;
                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = studentToUpdate.AverageScore;

                // Xóa dữ liệu trên các input sau khi sửa thành công
                masv.Clear();
                hoTen.Clear();
                dienTrungBinh.Clear();
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show(ex.Message);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem mã sinh viên có được nhập vào hay không.
                string studentID = masv.Text; // Lấy mã sinh viên từ ô input "masv".
                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa."); // Thông báo nếu chưa nhập mã sinh viên.
                    return;
                }

                // 2. Khởi tạo context để làm việc với database.
                Model1 context = new Model1();

                // 3. Tìm kiếm sinh viên cần xóa trong database dựa trên StudentID.
                var studentToDelete = context.Students.SingleOrDefault(s => s.StudentID == studentID);
                if (studentToDelete == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã sinh viên này."); // Thông báo nếu không tìm thấy.
                    return;
                }

                // 4. Xóa đối tượng sinh viên khỏi database.
                context.Students.Remove(studentToDelete);

                // 5. Lưu thay đổi vào database để xác nhận việc xóa.
                context.SaveChanges();

                // 6. Tìm và xóa dòng dữ liệu trong DataGridView tương ứng với StudentID.
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == studentID)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index); // Xóa dòng khỏi DataGridView.
                        break; // Thoát vòng lặp sau khi tìm và xóa.
                    }
                }

                // 7. Hiển thị thông báo xóa thành công.
                MessageBox.Show("Xóa sinh viên thành công.");

                // 8. Xóa dữ liệu trong các ô input sau khi xóa thành công.
                masv.Clear();
                hoTen.Clear();
                dienTrungBinh.Clear();
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // 9. Hiển thị thông báo lỗi nếu có vấn đề xảy ra.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
