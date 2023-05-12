
namespace NET7WinFormsWithSqliteTodos.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            this.Text = this.Text.Replace("User", userName);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }
    }
}
