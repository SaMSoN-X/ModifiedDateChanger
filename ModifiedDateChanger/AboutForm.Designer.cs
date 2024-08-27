namespace ModifiedDateChanger
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutHeaderLabel = new System.Windows.Forms.Label();
            this.AboutTextLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutHeaderLabel
            // 
            this.AboutHeaderLabel.AutoSize = true;
            this.AboutHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.AboutHeaderLabel.Name = "AboutHeaderLabel";
            this.AboutHeaderLabel.Size = new System.Drawing.Size(162, 32);
            this.AboutHeaderLabel.TabIndex = 0;
            this.AboutHeaderLabel.Text = "Изменить даты и время\r\nмодификаций файлов";
            // 
            // AboutTextLabel
            // 
            this.AboutTextLabel.AutoSize = true;
            this.AboutTextLabel.Location = new System.Drawing.Point(12, 282);
            this.AboutTextLabel.Name = "AboutTextLabel";
            this.AboutTextLabel.Size = new System.Drawing.Size(0, 13);
            this.AboutTextLabel.TabIndex = 1;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(13, 47);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(260, 225);
            this.LogoPictureBox.TabIndex = 2;
            this.LogoPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 416);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.AboutTextLabel);
            this.Controls.Add(this.AboutHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 455);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutHeaderLabel;
        private System.Windows.Forms.Label AboutTextLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}