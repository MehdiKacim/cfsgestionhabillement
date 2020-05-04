namespace cfsgestionhabillement.UIL.Accueil
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnParam = new Guna.UI.WinForms.GunaImageButton();
            this.lblNom = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btn_Home = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnBody = new Guna.UI.WinForms.GunaPanel();
            this.pHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.gunaPanel1.Controls.Add(this.btnParam);
            this.gunaPanel1.Controls.Add(this.lblNom);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(-5, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1091, 55);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnParam
            // 
            this.btnParam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnParam.Image = ((System.Drawing.Image)(resources.GetObject("btnParam.Image")));
            this.btnParam.ImageSize = new System.Drawing.Size(45, 45);
            this.btnParam.Location = new System.Drawing.Point(952, 3);
            this.btnParam.Name = "btnParam";
            this.btnParam.OnHoverImage = null;
            this.btnParam.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnParam.Size = new System.Drawing.Size(64, 52);
            this.btnParam.TabIndex = 5;
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(500, 17);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(22, 21);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1022, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(55, 55);
            this.gunaControlBox1.TabIndex = 1;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click_1);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(60, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "CFS - AGST";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.btn_Home);
            this.gunaPanel2.Location = new System.Drawing.Point(-8, 54);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1094, 45);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.Animated = true;
            this.btn_Home.AnimationHoverSpeed = 0.07F;
            this.btn_Home.AnimationSpeed = 0.03F;
            this.btn_Home.BaseColor = System.Drawing.Color.White;
            this.btn_Home.BorderColor = System.Drawing.Color.Black;
            this.btn_Home.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_Home.Checked = true;
            this.btn_Home.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_Home.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Home.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btn_Home.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.CheckedImage")));
            this.btn_Home.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Home.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btn_Home.Image = null;
            this.btn_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Home.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Home.LineBottom = 4;
            this.btn_Home.LineColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Home.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Home.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(150)))), ((int)(((byte)(168)))));
            this.btn_Home.OnHoverImage = null;
            this.btn_Home.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(150)))), ((int)(((byte)(168)))));
            this.btn_Home.OnPressedColor = System.Drawing.Color.White;
            this.btn_Home.OnPressedDepth = 0;
            this.btn_Home.Size = new System.Drawing.Size(180, 45);
            this.btn_Home.TabIndex = 14;
            this.btn_Home.Text = "Accueil";
            this.btn_Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pHome);
            this.pnBody.Location = new System.Drawing.Point(-5, 99);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1077, 353);
            this.pnBody.TabIndex = 2;
            // 
            // pHome
            // 
            this.pHome.Controls.Add(this.lblHome);
            this.pHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHome.Location = new System.Drawing.Point(0, 0);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1077, 353);
            this.pHome.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.White;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(91, 32);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Acceuil";
            // 
            // Accueil
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Accueil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.pHome.PerformLayout();
            this.ResumeLayout(false);

        }

        private void GunaControlBox1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Home;
        private Guna.UI.WinForms.GunaPanel pnBody;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lblNom;
        private Guna.UI.WinForms.GunaImageButton btnParam;
    }
}

