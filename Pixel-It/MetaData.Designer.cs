namespace Pixel_It
{
    partial class MetaData
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
            this.clear_metadata = new System.Windows.Forms.Button();
            this.listViewMetadata = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // clear_metadata
            // 
            this.clear_metadata.BackColor = System.Drawing.Color.DodgerBlue;
            this.clear_metadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_metadata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear_metadata.Location = new System.Drawing.Point(31, 341);
            this.clear_metadata.Name = "clear_metadata";
            this.clear_metadata.Size = new System.Drawing.Size(209, 35);
            this.clear_metadata.TabIndex = 1;
            this.clear_metadata.Text = "Clear Metadata";
            this.clear_metadata.UseVisualStyleBackColor = false;
            this.clear_metadata.Click += new System.EventHandler(this.clear_metadata_Click);
            // 
            // listViewMetadata
            // 
            this.listViewMetadata.HideSelection = false;
            this.listViewMetadata.Location = new System.Drawing.Point(32, 35);
            this.listViewMetadata.Name = "listViewMetadata";
            this.listViewMetadata.Size = new System.Drawing.Size(462, 289);
            this.listViewMetadata.TabIndex = 3;
            this.listViewMetadata.UseCompatibleStateImageBehavior = false;
            // 
            // MetaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 410);
            this.Controls.Add(this.listViewMetadata);
            this.Controls.Add(this.clear_metadata);
            this.Name = "MetaData";
            this.Text = "MetaData";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clear_metadata;
        private System.Windows.Forms.ListView listViewMetadata;
    }
}