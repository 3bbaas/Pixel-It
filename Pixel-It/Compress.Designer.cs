namespace Pixel_It
{
    partial class Compress
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.qualityTrackBar1 = new System.Windows.Forms.TrackBar();
            this.filterPreview1 = new Pixel_It.FilterPreview();
            this.filterCompressBox = new Pixel_It.FilterPreview();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(189, 403);
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
            this.applyBtn.Location = new System.Drawing.Point(23, 403);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(102, 34);
            this.applyBtn.TabIndex = 31;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.qualityLabel.Location = new System.Drawing.Point(19, 13);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(183, 24);
            this.qualityLabel.TabIndex = 30;
            this.qualityLabel.Text = "Quality (Orignal 100%)";
            // 
            // qualityTrackBar1
            // 
            this.qualityTrackBar1.Location = new System.Drawing.Point(23, 341);
            this.qualityTrackBar1.Name = "qualityTrackBar1";
            this.qualityTrackBar1.Size = new System.Drawing.Size(268, 56);
            this.qualityTrackBar1.TabIndex = 33;
            this.qualityTrackBar1.Scroll += new System.EventHandler(this.qualityTrackBar1_Scroll);
            // 
            // filterPreview1
            // 
            this.filterPreview1.Image = null;
            this.filterPreview1.Location = new System.Drawing.Point(189, 168);
            this.filterPreview1.Name = "filterPreview1";
            this.filterPreview1.Size = new System.Drawing.Size(8, 8);
            this.filterPreview1.TabIndex = 34;
            this.filterPreview1.Text = "filterPreview1";
            // 
            // filterCompressBox
            // 
            this.filterCompressBox.Image = null;
            this.filterCompressBox.Location = new System.Drawing.Point(23, 55);
            this.filterCompressBox.Name = "filterCompressBox";
            this.filterCompressBox.Size = new System.Drawing.Size(268, 247);
            this.filterCompressBox.TabIndex = 35;
            this.filterCompressBox.Text = "filterPreview2";
            // 
            // Compress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 460);
            this.Controls.Add(this.filterCompressBox);
            this.Controls.Add(this.filterPreview1);
            this.Controls.Add(this.qualityTrackBar1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.qualityLabel);
            this.Name = "Compress";
            this.Text = "Compress";
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.TrackBar qualityTrackBar1;
        private FilterPreview filterPreview1;
        private FilterPreview filterCompressBox;
    }
}