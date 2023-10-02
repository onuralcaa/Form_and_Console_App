namespace TelefonNumarasiDogrulamaUygulamasi
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
            this.btnNumberCheck = new System.Windows.Forms.Button();
            this.TelephoneNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNumberCheck
            // 
            this.btnNumberCheck.Location = new System.Drawing.Point(377, 196);
            this.btnNumberCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnNumberCheck.Name = "btnNumberCheck";
            this.btnNumberCheck.Size = new System.Drawing.Size(117, 39);
            this.btnNumberCheck.TabIndex = 0;
            this.btnNumberCheck.Text = "Check";
            this.btnNumberCheck.UseVisualStyleBackColor = true;
            this.btnNumberCheck.Click += new System.EventHandler(this.btnNumberCheck_Click);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.AutoSize = true;
            this.TelephoneNumber.Location = new System.Drawing.Point(172, 158);
            this.TelephoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.Size = new System.Drawing.Size(120, 20);
            this.TelephoneNumber.TabIndex = 1;
            this.TelephoneNumber.Text = "Phone Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(299, 155);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(305, 23);
            this.txtNumber.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.TelephoneNumber);
            this.Controls.Add(this.btnNumberCheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumberCheck;
        private System.Windows.Forms.Label TelephoneNumber;
        public System.Windows.Forms.TextBox txtNumber;
    }
}

