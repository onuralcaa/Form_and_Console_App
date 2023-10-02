namespace KurtAdamSaldirisi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textWeapon = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cbmBranch = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBoxWolfMan = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWolfMan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IRK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(218, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "BRANŞ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(152, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = " KULLANICI ADI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(227, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "SİLAH :";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(302, 12);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(194, 23);
            this.textUserName.TabIndex = 1;
            // 
            // textWeapon
            // 
            this.textWeapon.Location = new System.Drawing.Point(301, 125);
            this.textWeapon.Multiline = true;
            this.textWeapon.Name = "textWeapon";
            this.textWeapon.Size = new System.Drawing.Size(194, 23);
            this.textWeapon.TabIndex = 1;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(302, 52);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 24);
            this.cmbRace.TabIndex = 2;
            // 
            // cbmBranch
            // 
            this.cbmBranch.FormattingEnabled = true;
            this.cbmBranch.Items.AddRange(new object[] {
            "Archer",
            "Mage",
            "Warrior",
            "Assasin"});
            this.cbmBranch.Location = new System.Drawing.Point(301, 90);
            this.cbmBranch.Name = "cbmBranch";
            this.cbmBranch.Size = new System.Drawing.Size(121, 24);
            this.cbmBranch.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(528, 105);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(106, 43);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBoxWolfMan
            // 
            this.pictureBoxWolfMan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWolfMan.Image")));
            this.pictureBoxWolfMan.Location = new System.Drawing.Point(404, 226);
            this.pictureBoxWolfMan.Name = "pictureBoxWolfMan";
            this.pictureBoxWolfMan.Size = new System.Drawing.Size(297, 185);
            this.pictureBoxWolfMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWolfMan.TabIndex = 4;
            this.pictureBoxWolfMan.TabStop = false;
            this.pictureBoxWolfMan.Visible = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Red;
            this.lblHealth.Location = new System.Drawing.Point(401, 184);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(300, 27);
            this.lblHealth.TabIndex = 5;
            this.lblHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(167, 252);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(140, 102);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "SALDIR";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pictureBoxWolfMan);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbmBranch);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.textWeapon);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWolfMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textWeapon;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cbmBranch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pictureBoxWolfMan;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
    }
}

