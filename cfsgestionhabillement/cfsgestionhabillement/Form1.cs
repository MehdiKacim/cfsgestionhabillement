using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cfsgestionhabillement
{
    public partial class Main : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement de l'appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
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
