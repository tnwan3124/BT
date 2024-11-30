namespace Bai_Tap_Tren_Truong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Thêm mới vào ListView
        private void btThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các TextBox có rỗng không
            if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Tạo một ListViewItem mới với LastName
            ListViewItem lvi = new ListViewItem(txtLastName.Text);

            // Thêm FirstName và Phone vào SubItems
            lvi.SubItems.Add(txtFirstName.Text);
            lvi.SubItems.Add(txtPhone.Text);

            // Thêm mục vào ListView
            lvStudent.Items.Add(lvi);
        }

        // Sửa thông tin của mục đã chọn
        private void btSua_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn trong ListView
                ListViewItem selectedItem = lvStudent.SelectedItems[0];

                // Cập nhật các giá trị của SubItems
                selectedItem.SubItems[0].Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFirstName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        // Xóa mục đã chọn
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                // Xóa mục được chọn
                lvStudent.Items.Remove(lvStudent.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        // Khi chọn một mục trong ListView, điền thông tin vào các TextBox
        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = lvStudent.SelectedItems[0];

                // Điền thông tin vào các TextBox
                txtLastName.Text = selectedItem.SubItems[0].Text;
                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtPhone.Text = selectedItem.SubItems[2].Text;
            }
        }

        // Các sự kiện TextChanged có thể không cần thiết trong trường hợp này, nhưng nếu có thể sử dụng để xử lý khi người dùng nhập thông tin.
        private void txtFirstName_TextChanged(object sender, EventArgs e) { }

        private void txtLastName_TextChanged(object sender, EventArgs e) { }

        private void txtPhone_TextChanged(object sender, EventArgs e) { }
    }
}
