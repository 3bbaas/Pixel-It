namespace Pixel_It
{
    partial class Contrast
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
            this.filterContrastBox = new Pixel_It.FilterPreview();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.changeContrastBox = new System.Windows.Forms.TextBox();
            this.changeBrightnessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // filterContrastBox
            // 
            this.filterContrastBox.Image = null;
            this.filterContrastBox.Location = new System.Drawing.Point(311, 53);
            this.filterContrastBox.Name = "filterContrastBox";
            this.filterContrastBox.Size = new System.Drawing.Size(356, 294);
            this.filterContrastBox.TabIndex = 29;
            this.filterContrastBox.Text = "filterContrastBox";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(148, 313);
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
            this.applyBtn.Location = new System.Drawing.Point(18, 313);
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
            this.previewLabel.Location = new System.Drawing.Point(307, 26);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(71, 24);
            this.previewLabel.TabIndex = 26;
            this.previewLabel.Text = "Preview";
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(18, 76);
            this.contrastTrackBar.Maximum = 1000;
            this.contrastTrackBar.Minimum = -1000;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(256, 56);
            this.contrastTrackBar.TabIndex = 25;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // changeContrastBox
            // 
            this.changeContrastBox.Location = new System.Drawing.Point(201, 30);
            this.changeContrastBox.Name = "changeContrastBox";
            this.changeContrastBox.Size = new System.Drawing.Size(73, 22);
            this.changeContrastBox.TabIndex = 23;
            this.changeContrastBox.TextChanged += new System.EventHandler(this.changeContrastBox_TextChanged);
            // 
            // changeBrightnessLabel
            // 
            this.changeBrightnessLabel.AutoSize = true;
            this.changeBrightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBrightnessLabel.Location = new System.Drawing.Point(14, 26);
            this.changeBrightnessLabel.Name = "changeBrightnessLabel";
            this.changeBrightnessLabel.Size = new System.Drawing.Size(164, 20);
            this.changeBrightnessLabel.TabIndex = 24;
            this.changeBrightnessLabel.Text = "Change contrast by: ";
            this.changeBrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Contrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 375);
            this.Controls.Add(this.filterContrastBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.changeContrastBox);
            this.Controls.Add(this.changeBrightnessLabel);
            this.Name = "Contrast";
            this.Text = "Contrast";
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterPreview filterContrastBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.TextBox changeContrastBox;
        private System.Windows.Forms.Label changeBrightnessLabel;
    }
}