namespace Pixel_It
{
    partial class Gamma
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
            this.filterGammaBox = new Pixel_It.FilterPreview();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.GammaTrackBar = new System.Windows.Forms.TrackBar();
            this.changeGammaBox = new System.Windows.Forms.TextBox();
            this.changeBrightnessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // filterGammaBox
            // 
            this.filterGammaBox.Image = null;
            this.filterGammaBox.Location = new System.Drawing.Point(311, 37);
            this.filterGammaBox.Name = "filterGammaBox";
            this.filterGammaBox.Size = new System.Drawing.Size(356, 294);
            this.filterGammaBox.TabIndex = 29;
            this.filterGammaBox.Text = "filterGammaBox";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(148, 297);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 34);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.applyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applyBtn.Location = new System.Drawing.Point(18, 297);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(102, 34);
            this.applyBtn.TabIndex = 27;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.previewLabel.Location = new System.Drawing.Point(307, 10);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(71, 24);
            this.previewLabel.TabIndex = 26;
            this.previewLabel.Text = "Preview";
            // 
            // GammaTrackBar
            // 
            this.GammaTrackBar.Location = new System.Drawing.Point(18, 60);
            this.GammaTrackBar.Maximum = 1000;
            this.GammaTrackBar.Minimum = -1000;
            this.GammaTrackBar.Name = "GammaTrackBar";
            this.GammaTrackBar.Size = new System.Drawing.Size(256, 56);
            this.GammaTrackBar.TabIndex = 25;
            this.GammaTrackBar.Scroll += new System.EventHandler(this.GammaTrackBar_Scroll);
            // 
            // changeGammaBox
            // 
            this.changeGammaBox.Location = new System.Drawing.Point(201, 14);
            this.changeGammaBox.Name = "changeGammaBox";
            this.changeGammaBox.Size = new System.Drawing.Size(73, 22);
            this.changeGammaBox.TabIndex = 23;
            this.changeGammaBox.TextChanged += new System.EventHandler(this.changeGammaBox_TextChanged);
            // 
            // changeBrightnessLabel
            // 
            this.changeBrightnessLabel.AutoSize = true;
            this.changeBrightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBrightnessLabel.Location = new System.Drawing.Point(14, 14);
            this.changeBrightnessLabel.Name = "changeBrightnessLabel";
            this.changeBrightnessLabel.Size = new System.Drawing.Size(181, 20);
            this.changeBrightnessLabel.TabIndex = 24;
            this.changeBrightnessLabel.Text = "Change brightness by: ";
            this.changeBrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 352);
            this.Controls.Add(this.filterGammaBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.GammaTrackBar);
            this.Controls.Add(this.changeGammaBox);
            this.Controls.Add(this.changeBrightnessLabel);
            this.Name = "Gamma";
            this.Text = "Gamma";
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterPreview filterGammaBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.TrackBar GammaTrackBar;
        private System.Windows.Forms.TextBox changeGammaBox;
        private System.Windows.Forms.Label changeBrightnessLabel;
    }
}