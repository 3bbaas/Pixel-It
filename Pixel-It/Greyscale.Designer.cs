namespace Pixel_It
{
    partial class Greyscale
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
            this.greyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.greyBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.greyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // greyBtn
            // 
            this.greyBtn.BackColor = System.Drawing.Color.Gray;
            this.greyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.greyBtn.Location = new System.Drawing.Point(21, 390);
            this.greyBtn.Name = "greyBtn";
            this.greyBtn.Size = new System.Drawing.Size(356, 41);
            this.greyBtn.TabIndex = 10;
            this.greyBtn.Text = ">> Grey";
            this.greyBtn.UseVisualStyleBackColor = false;
            this.greyBtn.Click += new System.EventHandler(this.greyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Greyscale";
            // 
            // greyBox
            // 
            this.greyBox.Location = new System.Drawing.Point(21, 77);
            this.greyBox.Name = "greyBox";
            this.greyBox.Size = new System.Drawing.Size(356, 294);
            this.greyBox.TabIndex = 8;
            this.greyBox.TabStop = false;
            // 
            // Greyscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.greyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greyBox);
            this.Name = "Greyscale";
            this.Text = "Greyscale";
            ((System.ComponentModel.ISupportInitialize)(this.greyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button greyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox greyBox;
    }
}