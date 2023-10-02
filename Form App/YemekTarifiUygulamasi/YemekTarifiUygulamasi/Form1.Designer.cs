namespace YemekTarifiUygulamasi
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
            this.lstStages = new System.Windows.Forms.ListBox();
            this.btnAddStage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStages
            // 
            this.lstStages.FormattingEnabled = true;
            this.lstStages.ItemHeight = 20;
            this.lstStages.Location = new System.Drawing.Point(161, 96);
            this.lstStages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstStages.Name = "lstStages";
            this.lstStages.Size = new System.Drawing.Size(272, 304);
            this.lstStages.TabIndex = 0;
            // 
            // btnAddStage
            // 
            this.btnAddStage.Location = new System.Drawing.Point(708, 220);
            this.btnAddStage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStage.Name = "btnAddStage";
            this.btnAddStage.Size = new System.Drawing.Size(134, 79);
            this.btnAddStage.TabIndex = 1;
            this.btnAddStage.Text = "aşama ekle";
            this.btnAddStage.UseVisualStyleBackColor = true;
            this.btnAddStage.Click += new System.EventHandler(this.btnAddStage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnAddStage);
            this.Controls.Add(this.lstStages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStages;
        private System.Windows.Forms.Button btnAddStage;
    }
}

