using System;
using cfsgestionhabillement;
using System.Windows.Forms;

namespace cfsgestionhabillement.UIL.LogIN
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            tb_Password.PasswordChar = '*';
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
