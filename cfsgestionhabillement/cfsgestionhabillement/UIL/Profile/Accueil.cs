using System.Windows.Forms;
using System;
using System.Drawing;
using cfsgestionhabillement.Entity;

namespace cfsgestionhabillement.UIL.Accueil
{
    public partial class Accueil : Form
    {
        private Secouriste CurrentUser = null;
        /// <summary>
        /// Constructeur
        /// </summary>
        public Accueil()
        {
            InitializeComponent();
            if (!Security.Security.IsAuth)
            {
                MessageBox.Show("Vous n'avez pas l'autorisation d'acceder à cette page !");
                return;
            }
            CurrentUser = Security.Security.CurrentUser;
            lblNom.Text = $"Bonjour {CurrentUser.Prenom_Secouriste} {CurrentUser.Nom_Secouriste} ";


        }

        /// <summary>
        /// Chargement de l'appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);

        }

        /// <summary>
        /// btnParam_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParam_Click(object sender, EventArgs e)
        {
            Form fParams = new Parametres.FrmParametres();
            fParams.Show(this);
        }

        /// <summary>
        /// gunaControlBox1_Click_1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected private void gunaControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
