using System;
using System.Windows.Forms;
using cfsgestionhabillement.database;
using cfsgestionhabillement.Repository;
using System.Security.Cryptography;
using System.Text;
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
            bool IsAuth = false;
            string hash;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(tb_Password.Text);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            }
            if (tb_User.Text != String.Empty && tb_Password.Text != String.Empty)
            {
                IsAuth = userRepository.CheckConnexion(tb_User.Text, hash);
                if (IsAuth)
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("ko");
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir les champs");
            }
        }
    }
}
