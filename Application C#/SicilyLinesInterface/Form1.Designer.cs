
namespace SicilyLinesInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ListBoxReservation = new System.Windows.Forms.ListBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSuppr = new MetroFramework.Controls.MetroButton();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnPath = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.labelStatus = new MetroFramework.Controls.MetroLabel();
            this.lbAjoutLiaison = new System.Windows.Forms.Label();
            this.textBox_Ajout = new System.Windows.Forms.RichTextBox();
            this.lbModificationLiaison = new System.Windows.Forms.Label();
            this.textBox_Modification = new System.Windows.Forms.RichTextBox();
            this.btnOKAjout = new MetroFramework.Controls.MetroButton();
            this.btnModifOK = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnAccueil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 631);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Location = new System.Drawing.Point(0, 161);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(260, 42);
            this.btnReservation.TabIndex = 6;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Location = new System.Drawing.Point(0, 105);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 100);
            this.pnlNav.TabIndex = 5;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnAccueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccueil.ForeColor = System.Drawing.Color.White;
            this.btnAccueil.Location = new System.Drawing.Point(0, 119);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(260, 42);
            this.btnAccueil.TabIndex = 1;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccueil.UseVisualStyleBackColor = false;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            this.btnAccueil.Leave += new System.EventHandler(this.btnAccueil_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 119);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-45, -57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.metroButton2);
            this.panel3.Controls.Add(this.metroButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(260, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 47);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accueil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modification des réservation";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(130)))));
            this.metroButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(842, 12);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(22, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "-";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(130)))));
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(870, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(22, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "x";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ListBoxReservation
            // 
            this.ListBoxReservation.BackColor = System.Drawing.Color.White;
            this.ListBoxReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxReservation.FormattingEnabled = true;
            this.ListBoxReservation.ItemHeight = 15;
            this.ListBoxReservation.Location = new System.Drawing.Point(283, 84);
            this.ListBoxReservation.Name = "ListBoxReservation";
            this.ListBoxReservation.Size = new System.Drawing.Size(470, 302);
            this.ListBoxReservation.TabIndex = 2;
            this.ListBoxReservation.SelectedIndexChanged += new System.EventHandler(this.ListBoxReservation_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(283, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 44);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Mettre à jour ";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(441, 557);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(140, 44);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPath.Location = new System.Drawing.Point(283, 392);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(202, 23);
            this.textBoxPath.TabIndex = 6;
            this.textBoxPath.Text = "Emplacement du fichier .txt";
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(491, 392);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(59, 23);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "Ouvrir...";
            this.btnPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(556, 392);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Confirmer";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(984, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 44);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.Click += new System.EventHandler(this.metroButton3_ClickAsync);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(984, 601);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 0);
            this.labelStatus.TabIndex = 10;
            // 
            // lbAjoutLiaison
            // 
            this.lbAjoutLiaison.AutoSize = true;
            this.lbAjoutLiaison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbAjoutLiaison.Location = new System.Drawing.Point(774, 84);
            this.lbAjoutLiaison.Name = "lbAjoutLiaison";
            this.lbAjoutLiaison.Size = new System.Drawing.Size(73, 15);
            this.lbAjoutLiaison.TabIndex = 12;
            this.lbAjoutLiaison.Text = "Ajout liaison";
            // 
            // textBox_Ajout
            // 
            this.textBox_Ajout.Location = new System.Drawing.Point(774, 105);
            this.textBox_Ajout.Name = "textBox_Ajout";
            this.textBox_Ajout.Size = new System.Drawing.Size(350, 30);
            this.textBox_Ajout.TabIndex = 11;
            this.textBox_Ajout.Text = "";
            this.textBox_Ajout.TextChanged += new System.EventHandler(this.textBox_Ajout_TextChanged);
            // 
            // lbModificationLiaison
            // 
            this.lbModificationLiaison.AutoSize = true;
            this.lbModificationLiaison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbModificationLiaison.Location = new System.Drawing.Point(774, 178);
            this.lbModificationLiaison.Name = "lbModificationLiaison";
            this.lbModificationLiaison.Size = new System.Drawing.Size(75, 15);
            this.lbModificationLiaison.TabIndex = 14;
            this.lbModificationLiaison.Text = "Modification";
            // 
            // textBox_Modification
            // 
            this.textBox_Modification.Location = new System.Drawing.Point(774, 199);
            this.textBox_Modification.Name = "textBox_Modification";
            this.textBox_Modification.Size = new System.Drawing.Size(350, 30);
            this.textBox_Modification.TabIndex = 13;
            this.textBox_Modification.Text = "";
            // 
            // btnOKAjout
            // 
            this.btnOKAjout.Location = new System.Drawing.Point(1048, 142);
            this.btnOKAjout.Name = "btnOKAjout";
            this.btnOKAjout.Size = new System.Drawing.Size(75, 23);
            this.btnOKAjout.TabIndex = 15;
            this.btnOKAjout.Text = "OK";
            this.btnOKAjout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKAjout.Click += new System.EventHandler(this.btnOKAjout_Click);
            // 
            // btnModifOK
            // 
            this.btnModifOK.Location = new System.Drawing.Point(1048, 235);
            this.btnModifOK.Name = "btnModifOK";
            this.btnModifOK.Size = new System.Drawing.Size(75, 23);
            this.btnModifOK.TabIndex = 16;
            this.btnModifOK.Text = "OK";
            this.btnModifOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnModifOK.Click += new System.EventHandler(this.btnModifOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 631);
            this.Controls.Add(this.btnModifOK);
            this.Controls.Add(this.btnOKAjout);
            this.Controls.Add(this.lbModificationLiaison);
            this.Controls.Add(this.textBox_Modification);
            this.Controls.Add(this.lbAjoutLiaison);
            this.Controls.Add(this.textBox_Ajout);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ListBoxReservation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private UserControl2 userControl21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReservation;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnSuppr;
        private System.Windows.Forms.TextBox textBoxPath;
        private MetroFramework.Controls.MetroButton btnPath;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel labelStatus;
        private System.Windows.Forms.Label lbAjoutLiaison;
        private System.Windows.Forms.RichTextBox textBox_Ajout;
        private System.Windows.Forms.Label lbModificationLiaison;
        private System.Windows.Forms.RichTextBox textBox_Modification;
        private MetroFramework.Controls.MetroButton btnOKAjout;
        private MetroFramework.Controls.MetroButton btnModifOK;
    }
}

