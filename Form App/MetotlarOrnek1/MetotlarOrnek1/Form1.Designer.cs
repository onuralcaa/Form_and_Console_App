namespace MetotlarOrnek1
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
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShowNumber = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIncrement
            // 
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncrement.Location = new System.Drawing.Point(431, 172);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(120, 56);
            this.btnIncrement.TabIndex = 0;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecrement.Location = new System.Drawing.Point(198, 172);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(120, 56);
            this.btnDecrement.TabIndex = 0;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // labelShowNumber
            // 
            this.labelShowNumber.AutoSize = true;
            this.labelShowNumber.Location = new System.Drawing.Point(376, 74);
            this.labelShowNumber.Name = "labelShowNumber";
            this.labelShowNumber.Size = new System.Drawing.Size(0, 16);
            this.labelShowNumber.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(325, 306);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 46);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.labelShowNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelShowNumber;
        private System.Windows.Forms.Button btnShow;
    }
}

