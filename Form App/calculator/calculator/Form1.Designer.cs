namespace calculator
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
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNumber1.Location = new System.Drawing.Point(459, 158);
            this.textNumber1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textNumber1.Multiline = true;
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(195, 60);
            this.textNumber1.TabIndex = 0;
            // 
            // textNumber2
            // 
            this.textNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNumber2.Location = new System.Drawing.Point(684, 158);
            this.textNumber2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textNumber2.Multiline = true;
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(195, 60);
            this.textNumber2.TabIndex = 0;
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(459, 281);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(199, 71);
            this.btnTopla.TabIndex = 1;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(684, 281);
            this.btnCikar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(199, 71);
            this.btnCikar.TabIndex = 1;
            this.btnCikar.Text = "-";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.Location = new System.Drawing.Point(459, 356);
            this.btnCarp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(199, 71);
            this.btnCarp.TabIndex = 1;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBol.Location = new System.Drawing.Point(684, 356);
            this.btnBol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(199, 71);
            this.btnBol.TabIndex = 1;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1028);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
    }
}

