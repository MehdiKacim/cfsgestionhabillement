﻿namespace cfsgestionhabillement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btn_Connexion = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Home = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnBody = new Guna.UI.WinForms.GunaPanel();
            this.pHome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(-5, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1091, 55);
            this.gunaPanel1.TabIndex = 0;
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
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
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
            this.gunaPanel2.Controls.Add(this.btn_Connexion);
            this.gunaPanel2.Controls.Add(this.btn_Home);
            this.gunaPanel2.Location = new System.Drawing.Point(-8, 54);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1094, 45);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Animated = true;
            this.btn_Connexion.AnimationHoverSpeed = 0.07F;
            this.btn_Connexion.AnimationSpeed = 0.03F;
            this.btn_Connexion.BackColor = System.Drawing.Color.White;
            this.btn_Connexion.BaseColor = System.Drawing.Color.White;
            this.btn_Connexion.BorderColor = System.Drawing.Color.Black;
            this.btn_Connexion.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_Connexion.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_Connexion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Connexion.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btn_Connexion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Connexion.CheckedImage")));
            this.btn_Connexion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Connexion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Connexion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Connexion.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Connexion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_Connexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btn_Connexion.Image = null;
            this.btn_Connexion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Connexion.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Connexion.LineBottom = 4;
            this.btn_Connexion.LineColor = System.Drawing.Color.White;
            this.btn_Connexion.Location = new System.Drawing.Point(180, 0);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Connexion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Connexion.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(150)))), ((int)(((byte)(168)))));
            this.btn_Connexion.OnHoverImage = null;
            this.btn_Connexion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(150)))), ((int)(((byte)(168)))));
            this.btn_Connexion.OnPressedColor = System.Drawing.Color.White;
            this.btn_Connexion.OnPressedDepth = 0;
            this.btn_Connexion.Size = new System.Drawing.Size(180, 45);
            this.btn_Connexion.TabIndex = 15;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Connexion.Click += new System.EventHandler(this.Btn_Connexion_CheckedChanged);
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
            this.btn_Home.Text = "Home";
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
            this.pHome.Controls.Add(this.label3);
            this.pHome.Controls.Add(this.label2);
            this.pHome.Controls.Add(this.label9);
            this.pHome.Controls.Add(this.label8);
            this.pHome.Controls.Add(this.label7);
            this.pHome.Controls.Add(this.label6);
            this.pHome.Controls.Add(this.label1);
            this.pHome.Controls.Add(this.lblHome);
            this.pHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHome.Location = new System.Drawing.Point(0, 0);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1077, 353);
            this.pHome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(727, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "De plus de la géolocalisation, vous allez pouvoir envoyer des fiches d\'interventi" +
    "on afin de les optimisers.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cet outils permettera de géolocaliser les secouristes .";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(125, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Développeur et secouriste CFS 22";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(14, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mehdi KACIM - ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(14, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "En vous souhaitant une bonne utilisation.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(14, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cette application a été développée pour le CFS 22 .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bievenue sur l\'Application de Gestion des Secouristes sur le Terrain";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.White;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(80, 32);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.pHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Home;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Connexion;
        private Guna.UI.WinForms.GunaPanel pnBody;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

