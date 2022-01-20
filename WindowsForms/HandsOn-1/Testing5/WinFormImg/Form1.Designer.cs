namespace WinFormImg
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
            this.btnImg = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnImg.Location = new System.Drawing.Point(12, 12);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(337, 152);
            this.btnImg.TabIndex = 0;
            this.btnImg.Text = "Choose Image";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(56, 197);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(770, 348);
            this.imgBox.TabIndex = 1;
            this.imgBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 600);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.btnImg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Form1";
            this.Text = "Image Page";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

