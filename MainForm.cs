using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Lab04_01.Models;

namespace Lab04_01
{
  public partial class MainForm : Form
  {
    private StudentContextDB context = new StudentContextDB();

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load_1(object sender, EventArgs e)
    {
      LoadData();
      LoadFacultyToComboBox();
    }

    private void LoadData()
    {
      try
      {
        var data = context.Students.Include(s => s.Faculty).Select(s => new
        {
          s.StudentID,
          s.StudentName,
          FacultyName = s.Faculty.FacultyName,
          s.AverageScore
        }).ToList();
        dgvStudent.DataSource = data;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LoadFacultyToComboBox()
    {
      try
      {
        cmbFaculty.DataSource = context.Faculties.ToList();
        cmbFaculty.DisplayMember = "FacultyName";
        cmbFaculty.ValueMember = "FacultyID";
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi khi tải danh sách khoa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ResetForm()
    {
      txtStudentID.Clear();
      txtStudentName.Clear();
      txtAverageScore.Clear();
      cmbFaculty.SelectedIndex = -1;
      txtStudentID.Focus();
    }

    private bool ValidateForm()
    {
      if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
          string.IsNullOrWhiteSpace(txtStudentName.Text) ||
          string.IsNullOrWhiteSpace(txtAverageScore.Text) ||
          cmbFaculty.SelectedIndex == -1)
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      if (txtStudentID.Text.Length != 10)
      {
        MessageBox.Show("Mã sinh viên phải đúng 10 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      if (!System.Text.RegularExpressions.Regex.IsMatch(txtStudentName.Text,
          @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂƠƠẾỚÍÝỳýửạảấầẩẫậắằẳẵặẻẽếềểễệỉịọỏốồổỗộớờởỡợụủứừửữự\s]+$"
))
      {
        MessageBox.Show("Tên sinh viên chỉ được chứa chữ cái và khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      if (!double.TryParse(txtAverageScore.Text, out _))
      {
        MessageBox.Show("Điểm trung bình phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      double averageScore = double.Parse(txtAverageScore.Text);
      if (averageScore < 0 || averageScore > 10)
      {
        MessageBox.Show("Điểm trung bình phải trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      return true;
    }

    private void btnAdd_Click_1(object sender, EventArgs e)
    {
      if (!ValidateForm()) return;

      string studentID = txtStudentID.Text;
      if (context.Students.Any(s => s.StudentID == studentID))
      {
        MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      Student student = new Student
      {
        StudentID = studentID,
        StudentName = txtStudentName.Text,
        AverageScore = double.Parse(txtAverageScore.Text),
        FacultyID = (int)cmbFaculty.SelectedValue
      };

      context.Students.Add(student);
      context.SaveChanges();
      LoadData();
      ResetForm();
      MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnUpdate_Click_1(object sender, EventArgs e)
    {
      if (!ValidateForm()) return;

      DialogResult dlg = MessageBox.Show("Cập nhật dữ liệu cho sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.None);
      if (dlg == DialogResult.Yes)
      {
        string studentID = txtStudentID.Text;
        Student student = context.Students.FirstOrDefault(s => s.StudentID == studentID);

        if (student == null)
        {
          MessageBox.Show("Không tìm thấy mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        student.StudentName = txtStudentName.Text;
        student.AverageScore = double.Parse(txtAverageScore.Text);
        student.FacultyID = (int)cmbFaculty.SelectedValue;

        context.SaveChanges();
        LoadData();
        ResetForm();
        MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnDelete_Click_1(object sender, EventArgs e)
    {
      string studentID = txtStudentID.Text;
      Student student = context.Students.FirstOrDefault(s => s.StudentID == studentID);

      if (student == null)
      {
        MessageBox.Show("Không tìm thấy mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      DialogResult dialogResult = MessageBox.Show(
          "Bạn có chắc muốn xóa sinh viên này?",
          "Xác nhận",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning);

      if (dialogResult == DialogResult.Yes)
      {
        context.Students.Remove(student);
        context.SaveChanges();
        LoadData();
        ResetForm();
        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnRefill_Click(object sender, EventArgs e)
    {
      ResetForm();
    }

    private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        btnAdd_Click_1(sender, e);
      }
    }

    private void txtStudentName_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        btnAdd_Click_1(sender, e);
      }
    }

    private void cmbFaculty_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        btnAdd_Click_1(sender, e);
      }
    }

    private void txtAverageScore_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        btnAdd_Click_1(sender, e);
      }
    }

    private void dgvStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && dgvStudent.Rows[e.RowIndex].Cells["StudentID"].Value != null)
      {
        DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

        txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
        txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
        txtAverageScore.Text = row.Cells["AverageScore"].Value.ToString();
        string facultyName = row.Cells["FacultyName"].Value.ToString();
        cmbFaculty.SelectedIndex = cmbFaculty.FindStringExact(facultyName);
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      context.Dispose();
    }
  }
}
