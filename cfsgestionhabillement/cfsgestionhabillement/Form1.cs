using System;
using System.Drawing;
using System.Windows.Forms;
using cfsgestionhabillement.UIL.LogIN;
using cfsgestionhabillement.database;
using cfsgestionhabillement.Repository;
using cfsgestionhabillement.Entity;

namespace cfsgestionhabillement
{
    public partial class Main : Form
    {

        public User mUser = null;
        /// <summary>
        /// Constructeur
        /// </summary>
        public Main()
        {
            InitializeComponent();
            Btn_Home_CheckedChanged(null, null);
        }

        private void Btn_Connexion_CheckedChanged(object sender, System.EventArgs e)
        {
            if (btn_Connexion.Checked)
            {
                Form fLogin = new FrmLogin(this);
                fLogin.Show();
              
            }
        }

        private void Btn_Home_CheckedChanged(object sender, System.EventArgs e)
        {
            if (btn_Home.Checked) pHome.BringToFront();
        }

        /// <summary>
        /// Chargement de l'appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody,Color.Black,20,5,Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            
        }

        /// <summary>
        /// Fermerture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string message = "Voulez-vous vraiment fermer l'application ?";
            string caption = "Fermer l'application";

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
