namespace RandomNumberGenerate
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
            this.randombuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randombuton
            // 
            this.randombuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randombuton.Location = new System.Drawing.Point(220, 123);
            this.randombuton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randombuton.Name = "randombuton";
            this.randombuton.Size = new System.Drawing.Size(209, 72);
            this.randombuton.TabIndex = 0;
            this.randombuton.Text = "Sayı üret";
            this.randombuton.UseVisualStyleBackColor = true;
            this.randombuton.Click += new System.EventHandler(this.randombuton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 347);
            this.Controls.Add(this.randombuton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randombuton;
    }
}

