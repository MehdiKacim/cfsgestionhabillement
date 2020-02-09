using System;
using cfsgestionhabillement;
using System.Windows.Forms;
using cfsgestionhabillement.database;
using cfsgestionhabillement.Repository;
using cfsgestionhabillement.Entity;

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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Database d = new Database();
            UserRepository userRepository = new UserRepository(d);
            User user = null;
            if (tb_User.Text != String.Empty  && tb_Password.Text != String.Empty)
            {
                user = userRepository.CheckConnexion(tb_User.Text, tb_Password.Text);
            }
            else
            {
                MessageBox.Show("Merci de remplir les champs");
            }

        }
    }
}
