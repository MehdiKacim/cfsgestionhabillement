using System;
using System.Windows.Forms;
using cfsgestionhabillement.Repository;
using System.Security.Cryptography;
using System.Text;
using cfsgestionhabillement.UIL.Accueil;

namespace cfsgestionhabillement.UIL.LogIN
{
    public partial class FrmLogin : Form
    {
        private UserRepository userRepository;
        public FrmLogin()
        {
            InitializeComponent();
            tb_Password.PasswordChar = '*';
            userRepository = new UserRepository();
            lblErreur.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        /// <summary>
        /// fermer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (userRepository.Connection(tb_User.Text, GetSHA1FromStringValue(tb_Password.Text)))
            {
                Form fAccueil = new Accueil.Accueil();
                fAccueil.Show(this);
                this.Hide();
            }

            else
            {
                lblErreur.Visible = true;
            }

        }

        /// <summary>
        /// GetSHA1FromStringValue
        /// </summary>
        /// <param name="pStringValue"></param>
        /// <returns></returns>
        private string GetSHA1FromStringValue(string pStringValue)
        {
            string hash;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(tb_Password.Text);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
            return hash;
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
