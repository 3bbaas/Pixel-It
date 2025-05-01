namespace Pixel_It
{
    partial class GaussianBlur
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
            this.filterGaussianBlurBox = new Pixel_It.FilterPreview();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filterGaussianBlurBox
            // 
            this.filterGaussianBlurBox.Image = null;
            this.filterGaussianBlurBox.Location = new System.Drawing.Point(12, 37);
            this.filterGaussianBlurBox.Name = "filterGaussianBlurBox";
            this.filterGaussianBlurBox.Size = new System.Drawing.Size(356, 294);
            this.filterGaussianBlurBox.TabIndex = 33;
            this.filterGaussianBlurBox.Text = "filterGaussianBlurBox";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(213, 339);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 34);
            this.cancelBtn.TabIndex = 32;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.applyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applyBtn.Location = new System.Drawing.Point(47, 339);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(102, 34);
            this.applyBtn.TabIndex = 31;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.previewLabel.Location = new System.Drawing.Point(8, 10);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(71, 24);
            this.previewLabel.TabIndex = 30;
            this.previewLabel.Text = "Preview";
            // 
            // GaussianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 385);
            this.Controls.Add(this.filterGaussianBlurBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.previewLabel);
            this.Name = "GaussianBlur";
            this.Text = "GaussianBlur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterPreview filterGaussianBlurBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label previewLabel;
    }
}