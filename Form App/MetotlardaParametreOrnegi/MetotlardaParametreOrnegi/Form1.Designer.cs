namespace MetotlardaParametreOrnegi
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
            this.btnArcher = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArcher
            // 
            this.btnArcher.Location = new System.Drawing.Point(169, 172);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(125, 54);
            this.btnArcher.TabIndex = 0;
            this.btnArcher.Text = "Okçu";
            this.btnArcher.UseVisualStyleBackColor = true;
            this.btnArcher.Click += new System.EventHandler(this.btnArcher_Click);
            // 
            // btnMage
            // 
            this.btnMage.Location = new System.Drawing.Point(327, 172);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(125, 54);
            this.btnMage.TabIndex = 0;
            this.btnMage.Text = "Büyücü";
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnWarrior
            // 
            this.btnWarrior.Location = new System.Drawing.Point(487, 172);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(125, 54);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.Text = "Savaşçı";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.btnArcher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArcher;
        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnWarrior;
    }
}

