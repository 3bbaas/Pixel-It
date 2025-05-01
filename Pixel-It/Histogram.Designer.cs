namespace Pixel_It
{
    partial class Histogram
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
            this.histogramBox = new System.Windows.Forms.PictureBox();
            this.EqualizedHistogramBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.get_histogram = new System.Windows.Forms.Button();
            this.get_equzlized = new System.Windows.Forms.Button();
            this.get_histogram_equalized = new System.Windows.Forms.Button();
            this.equalizedFilterPreview = new Pixel_It.FilterPreview();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqualizedHistogramBox)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramBox
            // 
            this.histogramBox.Location = new System.Drawing.Point(12, 84);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(356, 294);
            this.histogramBox.TabIndex = 3;
            this.histogramBox.TabStop = false;
            // 
            // EqualizedHistogramBox
            // 
            this.EqualizedHistogramBox.Location = new System.Drawing.Point(793, 84);
            this.EqualizedHistogramBox.Name = "EqualizedHistogramBox";
            this.EqualizedHistogramBox.Size = new System.Drawing.Size(356, 294);
            this.EqualizedHistogramBox.TabIndex = 5;
            this.EqualizedHistogramBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Histogram";
            // 
            // get_histogram
            // 
            this.get_histogram.BackColor = System.Drawing.Color.RosyBrown;
            this.get_histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_histogram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.get_histogram.Location = new System.Drawing.Point(12, 397);
            this.get_histogram.Name = "get_histogram";
            this.get_histogram.Size = new System.Drawing.Size(356, 41);
            this.get_histogram.TabIndex = 7;
            this.get_histogram.Text = "Get Histogram";
            this.get_histogram.UseVisualStyleBackColor = false;
            this.get_histogram.Click += new System.EventHandler(this.get_histogram_Click);
            // 
            // get_equzlized
            // 
            this.get_equzlized.BackColor = System.Drawing.Color.RosyBrown;
            this.get_equzlized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_equzlized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.get_equzlized.Location = new System.Drawing.Point(402, 397);
            this.get_equzlized.Name = "get_equzlized";
            this.get_equzlized.Size = new System.Drawing.Size(356, 41);
            this.get_equzlized.TabIndex = 8;
            this.get_equzlized.Text = "Get Equalized Image";
            this.get_equzlized.UseVisualStyleBackColor = false;
            this.get_equzlized.Click += new System.EventHandler(this.get_equzlized_Click);
            // 
            // get_histogram_equalized
            // 
            this.get_histogram_equalized.BackColor = System.Drawing.Color.RosyBrown;
            this.get_histogram_equalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_histogram_equalized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.get_histogram_equalized.Location = new System.Drawing.Point(793, 397);
            this.get_histogram_equalized.Name = "get_histogram_equalized";
            this.get_histogram_equalized.Size = new System.Drawing.Size(356, 41);
            this.get_histogram_equalized.TabIndex = 9;
            this.get_histogram_equalized.Text = "Get Equalized Histogram";
            this.get_histogram_equalized.UseVisualStyleBackColor = false;
            this.get_histogram_equalized.Click += new System.EventHandler(this.get_histogram_equalized_Click);
            // 
            // equalizedFilterPreview
            // 
            this.equalizedFilterPreview.Image = null;
            this.equalizedFilterPreview.Location = new System.Drawing.Point(402, 84);
            this.equalizedFilterPreview.Name = "equalizedFilterPreview";
            this.equalizedFilterPreview.Size = new System.Drawing.Size(356, 294);
            this.equalizedFilterPreview.TabIndex = 10;
            this.equalizedFilterPreview.Text = "equalized";
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 449);
            this.Controls.Add(this.equalizedFilterPreview);
            this.Controls.Add(this.get_histogram_equalized);
            this.Controls.Add(this.get_equzlized);
            this.Controls.Add(this.get_histogram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EqualizedHistogramBox);
            this.Controls.Add(this.histogramBox);
            this.Name = "Histogram";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqualizedHistogramBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox histogramBox;
        private System.Windows.Forms.PictureBox EqualizedHistogramBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button get_histogram;
        private System.Windows.Forms.Button get_equzlized;
        private System.Windows.Forms.Button get_histogram_equalized;
        private FilterPreview equalizedFilterPreview;
    }
}