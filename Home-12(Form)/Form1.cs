namespace Home_12_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (emailTb.Text != "" && passwordTb.Text != "")
            {
                MessageBox.Show("Register successful");
            }
            else
            {
                MessageBox.Show("Error");
            }
          
        }

        private void passwordCb_CheckedChanged(object sender, EventArgs e)
        {
            passwordTb.PasswordChar = (passwordCb.Checked) ? '\0' : '*';
        }
    }
}
