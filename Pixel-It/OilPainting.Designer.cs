namespace Pixel_It
{
    partial class OilPainting
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
            this.filterOilPaintingBox = new Pixel_It.FilterPreview();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.oilPaintTrackBar = new System.Windows.Forms.TrackBar();
            this.changeOilPaintBox = new System.Windows.Forms.TextBox();
            this.changeBrightnessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oilPaintTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // filterOilPaintingBox
            // 
            this.filterOilPaintingBox.Image = null;
            this.filterOilPaintingBox.Location = new System.Drawing.Point(305, 45);
            this.filterOilPaintingBox.Name = "filterOilPaintingBox";
            this.filterOilPaintingBox.Size = new System.Drawing.Size(356, 294);
            this.filterOilPaintingBox.TabIndex = 29;
            this.filterOilPaintingBox.Text = "filterOilPaintingBox";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(142, 305);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 34);
            this.cancelBtn.TabIndex = 28;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.applyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applyBtn.Location = new System.Drawing.Point(12, 305);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(102, 34);
            this.applyBtn.TabIndex = 27;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click_1);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.previewLabel.Location = new System.Drawing.Point(301, 18);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(71, 24);
            this.previewLabel.TabIndex = 26;
            this.previewLabel.Text = "Preview";
            // 
            // oilPaintTrackBar
            // 
            this.oilPaintTrackBar.Location = new System.Drawing.Point(12, 68);
            this.oilPaintTrackBar.Maximum = 1000;
            this.oilPaintTrackBar.Minimum = -1000;
            this.oilPaintTrackBar.Name = "oilPaintTrackBar";
            this.oilPaintTrackBar.Size = new System.Drawing.Size(256, 56);
            this.oilPaintTrackBar.TabIndex = 25;
            this.oilPaintTrackBar.Scroll += new System.EventHandler(this.oilPaintTrackBar_Scroll);
            // 
            // changeOilPaintBox
            // 
            this.changeOilPaintBox.Location = new System.Drawing.Point(195, 22);
            this.changeOilPaintBox.Name = "changeOilPaintBox";
            this.changeOilPaintBox.Size = new System.Drawing.Size(73, 22);
            this.changeOilPaintBox.TabIndex = 23;
            this.changeOilPaintBox.TextChanged += new System.EventHandler(this.changeOilPaintBox_TextChanged);
            // 
            // changeBrightnessLabel
            // 
            this.changeBrightnessLabel.AutoSize = true;
            this.changeBrightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBrightnessLabel.Location = new System.Drawing.Point(8, 22);
            this.changeBrightnessLabel.Name = "changeBrightnessLabel";
            this.changeBrightnessLabel.Size = new System.Drawing.Size(181, 20);
            this.changeBrightnessLabel.TabIndex = 24;
            this.changeBrightnessLabel.Text = "Change brightness by: ";
            this.changeBrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OilPainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.filterOilPaintingBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.oilPaintTrackBar);
            this.Controls.Add(this.changeOilPaintBox);
            this.Controls.Add(this.changeBrightnessLabel);
            this.Name = "OilPainting";
            this.Text = "OilPainting";
            ((System.ComponentModel.ISupportInitialize)(this.oilPaintTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FilterPreview filterOilPaintingBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.TrackBar oilPaintTrackBar;
        private System.Windows.Forms.TextBox changeOilPaintBox;
        private System.Windows.Forms.Label changeBrightnessLabel;
    }
}