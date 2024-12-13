using System.Drawing;
using System.Windows.Forms;

namespace Lab04_01
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      // Declare controls
      private GroupBox groupBox;
      private Label lblStudentID, lblStudentName, lblFaculty, lblAverageScore;
      private TextBox txtStudentID, txtStudentName, txtAverageScore;
      private ComboBox cmbFaculty;
      private Button btnAdd, btnUpdate, btnDelete;
      private DataGridView dgvStudent;

      // Form's InitializeComponent method
      private void InitializeComponent()
      {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox = new System.Windows.Forms.GroupBox();
      this.lblStudentID = new System.Windows.Forms.Label();
      this.txtStudentID = new System.Windows.Forms.TextBox();
      this.lblStudentName = new System.Windows.Forms.Label();
      this.txtStudentName = new System.Windows.Forms.TextBox();
      this.lblFaculty = new System.Windows.Forms.Label();
      this.cmbFaculty = new System.Windows.Forms.ComboBox();
      this.lblAverageScore = new System.Windows.Forms.Label();
      this.txtAverageScore = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.dgvStudent = new System.Windows.Forms.DataGridView();
      this.btnRefill = new System.Windows.Forms.Button();
      this.groupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox
      // 
      this.groupBox.Controls.Add(this.lblStudentID);
      this.groupBox.Controls.Add(this.txtStudentID);
      this.groupBox.Controls.Add(this.lblStudentName);
      this.groupBox.Controls.Add(this.txtStudentName);
      this.groupBox.Controls.Add(this.lblFaculty);
      this.groupBox.Controls.Add(this.cmbFaculty);
      this.groupBox.Controls.Add(this.lblAverageScore);
      this.groupBox.Controls.Add(this.txtAverageScore);
      this.groupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
      this.groupBox.Location = new System.Drawing.Point(20, 20);
      this.groupBox.Name = "groupBox";
      this.groupBox.Padding = new System.Windows.Forms.Padding(10);
      this.groupBox.Size = new System.Drawing.Size(370, 200);
      this.groupBox.TabIndex = 0;
      this.groupBox.TabStop = false;
      this.groupBox.Text = "Thông tin sinh viên";
      // 
      // lblStudentID
      // 
      this.lblStudentID.Font = new System.Drawing.Font("Arial", 10F);
      this.lblStudentID.Location = new System.Drawing.Point(20, 30);
      this.lblStudentID.Name = "lblStudentID";
      this.lblStudentID.Size = new System.Drawing.Size(100, 23);
      this.lblStudentID.TabIndex = 0;
      this.lblStudentID.Text = "Mã sinh viên:";
      // 
      // txtStudentID
      // 
      this.txtStudentID.Font = new System.Drawing.Font("Arial", 10F);
      this.txtStudentID.Location = new System.Drawing.Point(150, 30);
      this.txtStudentID.Name = "txtStudentID";
      this.txtStudentID.Size = new System.Drawing.Size(200, 23);
      this.txtStudentID.TabIndex = 1;
      this.txtStudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentID_KeyDown);
      // 
      // lblStudentName
      // 
      this.lblStudentName.Font = new System.Drawing.Font("Arial", 10F);
      this.lblStudentName.Location = new System.Drawing.Point(20, 70);
      this.lblStudentName.Name = "lblStudentName";
      this.lblStudentName.Size = new System.Drawing.Size(100, 23);
      this.lblStudentName.TabIndex = 2;
      this.lblStudentName.Text = "Họ tên:";
      // 
      // txtStudentName
      // 
      this.txtStudentName.Font = new System.Drawing.Font("Arial", 10F);
      this.txtStudentName.Location = new System.Drawing.Point(150, 70);
      this.txtStudentName.Name = "txtStudentName";
      this.txtStudentName.Size = new System.Drawing.Size(200, 23);
      this.txtStudentName.TabIndex = 3;
      this.txtStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentName_KeyDown);
      // 
      // lblFaculty
      // 
      this.lblFaculty.Font = new System.Drawing.Font("Arial", 10F);
      this.lblFaculty.Location = new System.Drawing.Point(20, 110);
      this.lblFaculty.Name = "lblFaculty";
      this.lblFaculty.Size = new System.Drawing.Size(100, 23);
      this.lblFaculty.TabIndex = 4;
      this.lblFaculty.Text = "Khoa:";
      // 
      // cmbFaculty
      // 
      this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFaculty.Font = new System.Drawing.Font("Arial", 10F);
      this.cmbFaculty.Location = new System.Drawing.Point(150, 110);
      this.cmbFaculty.Name = "cmbFaculty";
      this.cmbFaculty.Size = new System.Drawing.Size(200, 24);
      this.cmbFaculty.TabIndex = 5;
      this.cmbFaculty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFaculty_KeyDown);
      // 
      // lblAverageScore
      // 
      this.lblAverageScore.Font = new System.Drawing.Font("Arial", 10F);
      this.lblAverageScore.Location = new System.Drawing.Point(20, 150);
      this.lblAverageScore.Name = "lblAverageScore";
      this.lblAverageScore.Size = new System.Drawing.Size(100, 23);
      this.lblAverageScore.TabIndex = 6;
      this.lblAverageScore.Text = "Điểm TB:";
      // 
      // txtAverageScore
      // 
      this.txtAverageScore.Font = new System.Drawing.Font("Arial", 10F);
      this.txtAverageScore.Location = new System.Drawing.Point(150, 150);
      this.txtAverageScore.Name = "txtAverageScore";
      this.txtAverageScore.Size = new System.Drawing.Size(200, 23);
      this.txtAverageScore.TabIndex = 7;
      this.txtAverageScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAverageScore_KeyDown);
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.ForeColor = System.Drawing.Color.Black;
      this.btnAdd.Location = new System.Drawing.Point(418, 45);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(90, 35);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnUpdate.BackColor = System.Drawing.Color.LightGreen;
      this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.ForeColor = System.Drawing.Color.Black;
      this.btnUpdate.Location = new System.Drawing.Point(418, 85);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(90, 35);
      this.btnUpdate.TabIndex = 2;
      this.btnUpdate.Text = "Cập nhật";
      this.btnUpdate.UseVisualStyleBackColor = false;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.ForeColor = System.Drawing.Color.Black;
      this.btnDelete.Location = new System.Drawing.Point(418, 125);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(90, 35);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Xóa";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
      // 
      // dgvStudent
      // 
      this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
      this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
      dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle12;
      this.dgvStudent.Location = new System.Drawing.Point(20, 230);
      this.dgvStudent.Name = "dgvStudent";
      this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvStudent.Size = new System.Drawing.Size(636, 309);
      this.dgvStudent.TabIndex = 4;
      this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick_1);
      // 
      // btnRefill
      // 
      this.btnRefill.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnRefill.BackColor = System.Drawing.Color.LightSalmon;
      this.btnRefill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRefill.ForeColor = System.Drawing.Color.Black;
      this.btnRefill.Location = new System.Drawing.Point(418, 165);
      this.btnRefill.Name = "btnRefill";
      this.btnRefill.Size = new System.Drawing.Size(90, 35);
      this.btnRefill.TabIndex = 3;
      this.btnRefill.Text = "Nhập lại";
      this.btnRefill.UseVisualStyleBackColor = false;
      this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(674, 551);
      this.Controls.Add(this.groupBox);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnRefill);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.dgvStudent);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "QUẢN LÝ SINH VIÊN";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load_1);
      this.groupBox.ResumeLayout(false);
      this.groupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion

    private Button btnRefill;
  }
}
