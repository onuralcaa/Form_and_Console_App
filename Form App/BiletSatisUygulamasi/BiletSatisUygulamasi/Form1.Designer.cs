namespace BiletSatisUygulamasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkış noktası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varış noktası";
            // 
            // comboFrom
            // 
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(390, 159);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(194, 32);
            this.comboFrom.TabIndex = 2;
            this.comboFrom.SelectedValueChanged += new System.EventHandler(this.comboFrom_SelectedValueChanged);
            // 
            // comboTo
            // 
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(765, 160);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(193, 32);
            this.comboTo.TabIndex = 2;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(803, 293);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(207, 52);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Satın al";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 534);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Button btnBuy;
    }
}

