using System;
using System.Windows.Forms;
using cfsgestionhabillement.Repository;
using cfsgestionhabillement.Entity;
using System.Collections.Generic;

namespace cfsgestionhabillement.UIL.Parametres
{
    public partial class FrmParametres : Form
    {
        private Secouriste Currentuser = null;
        private FonctionRepository fonctionRepository;
        private UserRepository userRepository;


        public FrmParametres()
        {
            InitializeComponent();
            gunaPanel1.Width = this.Width + 5;
            Currentuser = Security.Security.CurrentUser;
            fonctionRepository = new FonctionRepository();
            userRepository = new UserRepository();
            Binding();

            lblErreurMail.Visible = false;
            lblErreurNum.Visible = false;
            lblCP.Visible = false;
        }

        /// <summary>
        /// Binding
        /// </summary>
        public void Binding()
        {
            tb_Nom.Text = Currentuser.Nom_Secouriste;
            tb_Nom.ReadOnly = true;

            tb_Prenom.Text = Currentuser.Prenom_Secouriste;
            tb_Prenom.ReadOnly = true;

            tb_Role.Text = GetRoleapplicatif().Libelle_Fonction;
            tb_Role.ReadOnly = true;

            tbCp.Text = Currentuser.CodePostal_Secouriste;

            tb_Adresse.Text = Currentuser.Adresse_Secouriste;

            tb_Mail.Text = Currentuser.Email_Secouriste;

            tb_NumTel.Text = Currentuser.NumeroTel_Secouriste;

            tb_Ville.Text = Currentuser.Ville_Secouriste;

            dt_Naissance.Value = Currentuser.DateNaissance_Secouriste;
        }

        private roleapplicatif GetRoleapplicatif()
        {
            return fonctionRepository.GetFonctionCurrentUser();
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


        private void btn_Save_Click(object sender, EventArgs e)
        {

            Currentuser.CodePostal_Secouriste = tbCp.Text;
            Currentuser.Adresse_Secouriste = tb_Adresse.Text;
            Currentuser.Email_Secouriste = tb_Mail.Text;
            Currentuser.NumeroTel_Secouriste = tb_NumTel.Text;
            Currentuser.Ville_Secouriste = tb_Ville.Text;
            Currentuser.DateNaissance_Secouriste = dt_Naissance.Value;

            Dictionary<string, bool> result = userRepository.CheckRow(Currentuser);
            bool bSave = true;

            if (result["CodePostal_Secouriste"] == false)
            {
                bSave = false;
                lblCP.Visible = true;
            }
            else
            {
                lblCP.Visible = false;
            }


            if (result["Num_Tel"] == false)
            {
                bSave = false;
                lblErreurNum.Visible = true;
            }
            else
            {
                lblErreurNum.Visible = false;
            }

            if (result["Email"] == false)
            {
                bSave = false;
                lblErreurMail.Visible = true;
            }
            else
            {
                lblErreurMail.Visible = false;


            }

            if (!bSave) return;

            if(userRepository.Update(Currentuser))
            {
                MessageBox.Show("Vos informations ont bien été modifiée !");
            }

        }
    }
}
