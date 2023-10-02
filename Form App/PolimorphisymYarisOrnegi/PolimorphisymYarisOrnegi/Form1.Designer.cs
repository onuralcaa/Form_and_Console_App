namespace PolimorphisymYarisOrnegi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureHasan = new System.Windows.Forms.PictureBox();
            this.pictureDirin = new System.Windows.Forms.PictureBox();
            this.pictureHüseyin = new System.Windows.Forms.PictureBox();
            this.pictureSay = new System.Windows.Forms.PictureBox();
            this.pictureIhsan = new System.Windows.Forms.PictureBox();
            this.labelFinish = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDirin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHüseyin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIhsan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHasan
            // 
            this.pictureHasan.Image = ((System.Drawing.Image)(resources.GetObject("pictureHasan.Image")));
            this.pictureHasan.Location = new System.Drawing.Point(12, 9);
            this.pictureHasan.Name = "pictureHasan";
            this.pictureHasan.Size = new System.Drawing.Size(100, 107);
            this.pictureHasan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHasan.TabIndex = 0;
            this.pictureHasan.TabStop = false;
            // 
            // pictureDirin
            // 
            this.pictureDirin.Image = ((System.Drawing.Image)(resources.GetObject("pictureDirin.Image")));
            this.pictureDirin.Location = new System.Drawing.Point(12, 106);
            this.pictureDirin.Name = "pictureDirin";
            this.pictureDirin.Size = new System.Drawing.Size(100, 105);
            this.pictureDirin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDirin.TabIndex = 0;
            this.pictureDirin.TabStop = false;
            // 
            // pictureHüseyin
            // 
            this.pictureHüseyin.Image = ((System.Drawing.Image)(resources.GetObject("pictureHüseyin.Image")));
            this.pictureHüseyin.Location = new System.Drawing.Point(12, 208);
            this.pictureHüseyin.Name = "pictureHüseyin";
            this.pictureHüseyin.Size = new System.Drawing.Size(100, 110);
            this.pictureHüseyin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHüseyin.TabIndex = 0;
            this.pictureHüseyin.TabStop = false;
            // 
            // pictureSay
            // 
            this.pictureSay.Image = ((System.Drawing.Image)(resources.GetObject("pictureSay.Image")));
            this.pictureSay.Location = new System.Drawing.Point(12, 318);
            this.pictureSay.Name = "pictureSay";
            this.pictureSay.Size = new System.Drawing.Size(100, 107);
            this.pictureSay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSay.TabIndex = 0;
            this.pictureSay.TabStop = false;
            // 
            // pictureIhsan
            // 
            this.pictureIhsan.Image = ((System.Drawing.Image)(resources.GetObject("pictureIhsan.Image")));
            this.pictureIhsan.Location = new System.Drawing.Point(12, 420);
            this.pictureIhsan.Name = "pictureIhsan";
            this.pictureIhsan.Size = new System.Drawing.Size(100, 103);
            this.pictureIhsan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIhsan.TabIndex = 0;
            this.pictureIhsan.TabStop = false;
            // 
            // labelFinish
            // 
            this.labelFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinish.Location = new System.Drawing.Point(701, 9);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(34, 514);
            this.labelFinish.TabIndex = 1;
            this.labelFinish.Text = "FINISH";
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonStart.Location = new System.Drawing.Point(741, 480);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(101, 43);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 535);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.pictureIhsan);
            this.Controls.Add(this.pictureSay);
            this.Controls.Add(this.pictureHüseyin);
            this.Controls.Add(this.pictureDirin);
            this.Controls.Add(this.pictureHasan);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureHasan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDirin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHüseyin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIhsan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHasan;
        private System.Windows.Forms.PictureBox pictureDirin;
        private System.Windows.Forms.PictureBox pictureHüseyin;
        private System.Windows.Forms.PictureBox pictureSay;
        private System.Windows.Forms.PictureBox pictureIhsan;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

