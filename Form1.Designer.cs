namespace Bai_Tap_Tren_Truong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvStudent = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            lbFName = new Label();
            lbLName = new Label();
            lbPhone = new Label();
            SuspendLayout();
            // 
            // lvStudent
            // 
            lvStudent.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvStudent.Location = new Point(109, 122);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new Size(331, 210);
            lvStudent.TabIndex = 0;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
            lvStudent.SelectedIndexChanged += lvStudent_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "First Name";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Last Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 120;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(616, 146);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(616, 207);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 2;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(616, 275);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // btThem
            // 
            btThem.Location = new Point(109, 358);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 5;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(231, 358);
            btSua.Name = "btSua";
            btSua.Size = new Size(95, 29);
            btSua.TabIndex = 6;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(363, 358);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 7;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // lbFName
            // 
            lbFName.AutoSize = true;
            lbFName.Location = new Point(486, 151);
            lbFName.Name = "lbFName";
            lbFName.Size = new Size(80, 20);
            lbFName.TabIndex = 8;
            lbFName.Text = "First Name";
            // 
            // lbLName
            // 
            lbLName.AutoSize = true;
            lbLName.Location = new Point(486, 214);
            lbLName.Name = "lbLName";
            lbLName.Size = new Size(79, 20);
            lbLName.TabIndex = 9;
            lbLName.Text = "Last Name";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(486, 282);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 10;
            lbPhone.Text = "Phone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPhone);
            Controls.Add(lbLName);
            Controls.Add(lbFName);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThem);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lvStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvStudent;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private Label lbFName;
        private Label lbLName;
        private Label lbPhone;
    }
}
