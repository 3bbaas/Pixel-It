namespace Pixel_It
{
    partial class Brightness
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
            this.previewLabel = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.changeBrightnessBox = new System.Windows.Forms.TextBox();
            this.changeBrightnessLabel = new System.Windows.Forms.Label();
            this.filterBrightnessBox = new Pixel_It.FilterPreview();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(156, 311);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 34);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.applyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applyBtn.Location = new System.Drawing.Point(26, 311);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(102, 34);
            this.applyBtn.TabIndex = 19;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.previewLabel.Location = new System.Drawing.Point(315, 24);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(71, 24);
            this.previewLabel.TabIndex = 18;
            this.previewLabel.Text = "Preview";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(26, 74);
            this.brightnessTrackBar.Maximum = 1000;
            this.brightnessTrackBar.Minimum = -1000;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(256, 56);
            this.brightnessTrackBar.TabIndex = 17;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // changeBrightnessBox
            // 
            this.changeBrightnessBox.Location = new System.Drawing.Point(209, 28);
            this.changeBrightnessBox.Name = "changeBrightnessBox";
            this.changeBrightnessBox.Size = new System.Drawing.Size(73, 22);
            this.changeBrightnessBox.TabIndex = 15;
            this.changeBrightnessBox.TextChanged += new System.EventHandler(this.changeBrightnessBox_TextChanged);
            // 
            // changeBrightnessLabel
            // 
            this.changeBrightnessLabel.AutoSize = true;
            this.changeBrightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBrightnessLabel.Location = new System.Drawing.Point(22, 28);
            this.changeBrightnessLabel.Name = "changeBrightnessLabel";
            this.changeBrightnessLabel.Size = new System.Drawing.Size(181, 20);
            this.changeBrightnessLabel.TabIndex = 16;
            this.changeBrightnessLabel.Text = "Change brightness by: ";
            this.changeBrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterBrightnessBox
            // 
            this.filterBrightnessBox.Image = null;
            this.filterBrightnessBox.Location = new System.Drawing.Point(319, 51);
            this.filterBrightnessBox.Name = "filterBrightnessBox";
            this.filterBrightnessBox.Size = new System.Drawing.Size(356, 294);
            this.filterBrightnessBox.TabIndex = 22;
            this.filterBrightnessBox.Text = "filterBrightnessBox";
            // 
            // Brightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.Controls.Add(this.filterBrightnessBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.changeBrightnessBox);
            this.Controls.Add(this.changeBrightnessLabel);
            this.Name = "Brightness";
            this.Text = "Brightness";
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TextBox changeBrightnessBox;
        private System.Windows.Forms.Label changeBrightnessLabel;
        private FilterPreview filterBrightnessBox;
    }
}