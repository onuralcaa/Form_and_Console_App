namespace HesapMakinesi_Ornegi
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMines = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDiviedby = new System.Windows.Forms.Button();
            this.textValue = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(291, 155);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(148, 55);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMines
            // 
            this.btnMines.Location = new System.Drawing.Point(291, 225);
            this.btnMines.Name = "btnMines";
            this.btnMines.Size = new System.Drawing.Size(148, 55);
            this.btnMines.TabIndex = 0;
            this.btnMines.Text = "-";
            this.btnMines.UseVisualStyleBackColor = true;
            this.btnMines.Click += new System.EventHandler(this.btnMines_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(291, 299);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(148, 55);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDiviedby
            // 
            this.btnDiviedby.Location = new System.Drawing.Point(291, 369);
            this.btnDiviedby.Name = "btnDiviedby";
            this.btnDiviedby.Size = new System.Drawing.Size(148, 55);
            this.btnDiviedby.TabIndex = 0;
            this.btnDiviedby.Text = "/";
            this.btnDiviedby.UseVisualStyleBackColor = true;
            this.btnDiviedby.Click += new System.EventHandler(this.btnDiviedby_Click);
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(291, 67);
            this.textValue.Multiline = true;
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(314, 44);
            this.textValue.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Result.Location = new System.Drawing.Point(498, 225);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(174, 55);
            this.Result.TabIndex = 2;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 548);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.btnDiviedby);
            this.Controls.Add(this.btnMines);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMines;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDiviedby;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button Result;
    }
}

