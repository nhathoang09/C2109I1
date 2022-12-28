namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Hi", "Nhật Hoàng", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes", "Nhật Hoàng");
            }
            else
            {
                MessageBox.Show("No", "Nhật Hoàng");
            }
        }
    }
}