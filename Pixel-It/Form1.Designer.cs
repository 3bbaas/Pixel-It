namespace Pixel_It
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInAllFormatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMetaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.metaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPaintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelEdgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.OpenToolBar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.zoominToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.zoomoutToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.flipVerticalToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.flipHorizontalToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateLToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.rotateRtoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterPreview1 = new Pixel_It.FilterPreview();
            this.menuStrip1.SuspendLayout();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.adjustmentsToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.saveInAllFormatsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.saveasToolStripMenuItem.Text = "Save &as";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveasToolStripMenuItem_Click);
            // 
            // saveInAllFormatsToolStripMenuItem
            // 
            this.saveInAllFormatsToolStripMenuItem.Name = "saveInAllFormatsToolStripMenuItem";
            this.saveInAllFormatsToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.saveInAllFormatsToolStripMenuItem.Text = "Save in all formats";
            this.saveInAllFormatsToolStripMenuItem.Click += new System.EventHandler(this.saveInAllFormatsToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.clearMetaDataToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.compressToolStripMenuItem.Text = "Compress";
            this.compressToolStripMenuItem.Click += new System.EventHandler(this.compressToolStripMenuItem_Click);
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.flipToolStripMenuItem.Text = "Flip";
            this.flipToolStripMenuItem.Click += new System.EventHandler(this.flipToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.verticalToolStripMenuItem.Text = "&Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.horizontalToolStripMenuItem.Text = "&Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.degToLeftToolStripMenuItem,
            this.degToRightToolStripMenuItem});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // degToLeftToolStripMenuItem
            // 
            this.degToLeftToolStripMenuItem.Name = "degToLeftToolStripMenuItem";
            this.degToLeftToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.degToLeftToolStripMenuItem.Text = "90 deg to Left";
            this.degToLeftToolStripMenuItem.Click += new System.EventHandler(this.degToLeftToolStripMenuItem_Click);
            // 
            // degToRightToolStripMenuItem
            // 
            this.degToRightToolStripMenuItem.Name = "degToRightToolStripMenuItem";
            this.degToRightToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.degToRightToolStripMenuItem.Text = "90 deg to right";
            this.degToRightToolStripMenuItem.Click += new System.EventHandler(this.degToRightToolStripMenuItem_Click);
            // 
            // clearMetaDataToolStripMenuItem
            // 
            this.clearMetaDataToolStripMenuItem.Name = "clearMetaDataToolStripMenuItem";
            this.clearMetaDataToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.clearMetaDataToolStripMenuItem.Text = "Clear MetaData";
            this.clearMetaDataToolStripMenuItem.Click += new System.EventHandler(this.clearMetaDataToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcHistogram,
            this.metaDataToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.histogramToolStripMenuItem.Text = "View";
            // 
            // calcHistogram
            // 
            this.calcHistogram.Name = "calcHistogram";
            this.calcHistogram.Size = new System.Drawing.Size(162, 26);
            this.calcHistogram.Text = "Histogram";
            this.calcHistogram.Click += new System.EventHandler(this.calcHistogram_Click);
            // 
            // metaDataToolStripMenuItem
            // 
            this.metaDataToolStripMenuItem.Name = "metaDataToolStripMenuItem";
            this.metaDataToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.metaDataToolStripMenuItem.Text = "MetaData";
            this.metaDataToolStripMenuItem.Click += new System.EventHandler(this.metaDataToolStripMenuItem_Click);
            // 
            // adjustmentsToolStripMenuItem
            // 
            this.adjustmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelsToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.toolStripSeparator1,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem});
            this.adjustmentsToolStripMenuItem.Name = "adjustmentsToolStripMenuItem";
            this.adjustmentsToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.adjustmentsToolStripMenuItem.Text = "&Adjustments";
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.channelsToolStripMenuItem.Text = "Channels";
            this.channelsToolStripMenuItem.Click += new System.EventHandler(this.channelsToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oilPaintingToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sobelEdgeDetectionToolStripMenuItem,
            this.gammaToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.effectsToolStripMenuItem.Text = "&Effects";
            // 
            // oilPaintingToolStripMenuItem
            // 
            this.oilPaintingToolStripMenuItem.Name = "oilPaintingToolStripMenuItem";
            this.oilPaintingToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.oilPaintingToolStripMenuItem.Text = "&Oil Painting";
            this.oilPaintingToolStripMenuItem.Click += new System.EventHandler(this.oilPaintingToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.negativeToolStripMenuItem.Text = "&Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // sobelEdgeDetectionToolStripMenuItem
            // 
            this.sobelEdgeDetectionToolStripMenuItem.Name = "sobelEdgeDetectionToolStripMenuItem";
            this.sobelEdgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.sobelEdgeDetectionToolStripMenuItem.Text = "Sobel Edge Detection";
            this.sobelEdgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.sobelEdgeDetectionToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolBar,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.resizeToolStripButton4,
            this.toolStripSeparator6,
            this.zoominToolStripButton4,
            this.zoomoutToolStripButton4,
            this.toolStripSeparator7,
            this.flipVerticalToolStripButton4,
            this.flipHorizontalToolStripButton4,
            this.toolStripSeparator8,
            this.rotateLToolStripButton4,
            this.rotateRtoolStripButton4,
            this.toolStripSeparator9});
            this.toolBar.Location = new System.Drawing.Point(0, 30);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(840, 31);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolBar";
            // 
            // OpenToolBar
            // 
            this.OpenToolBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolBar.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolBar.Image")));
            this.OpenToolBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolBar.Name = "OpenToolBar";
            this.OpenToolBar.Size = new System.Drawing.Size(29, 28);
            this.OpenToolBar.Text = "OpenToolBar";
            this.OpenToolBar.ToolTipText = "Open";
            this.OpenToolBar.Click += new System.EventHandler(this.OpenToolBar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "Convert to R, G, B";
            this.toolStripButton2.Click += new System.EventHandler(this.rgbStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "Show Histogram";
            this.toolStripButton3.Click += new System.EventHandler(this.histogramStripButton3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // resizeToolStripButton4
            // 
            this.resizeToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resizeToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("resizeToolStripButton4.Image")));
            this.resizeToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resizeToolStripButton4.Name = "resizeToolStripButton4";
            this.resizeToolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.resizeToolStripButton4.Text = "Fit";
            this.resizeToolStripButton4.Click += new System.EventHandler(this.resizeToolStripButton4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // zoominToolStripButton4
            // 
            this.zoominToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoominToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("zoominToolStripButton4.Image")));
            this.zoominToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoominToolStripButton4.Name = "zoominToolStripButton4";
            this.zoominToolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.zoominToolStripButton4.Text = "Zoom In";
            this.zoominToolStripButton4.Click += new System.EventHandler(this.zoominToolStripButton4_Click);
            // 
            // zoomoutToolStripButton4
            // 
            this.zoomoutToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomoutToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("zoomoutToolStripButton4.Image")));
            this.zoomoutToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomoutToolStripButton4.Name = "zoomoutToolStripButton4";
            this.zoomoutToolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.zoomoutToolStripButton4.Text = "Zoom Out";
            this.zoomoutToolStripButton4.Click += new System.EventHandler(this.zoomoutToolStripButton4_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // flipVerticalToolStripButton4
            // 
            this.flipVerticalToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flipVerticalToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalToolStripButton4.Image")));
            this.flipVerticalToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipVerticalToolStripButton4.Name = "flipVerticalToolStripButton4";
            this.flipVerticalToolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.flipVerticalToolStripButton4.Text = "Flip Vertical";
            this.flipVerticalToolStripButton4.Click += new System.EventHandler(this.flipVerticalToolStripButton4_Click);
            // 
            // flipHorizontalToolStripButton4
            // 
            this.flipHorizontalToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flipHorizontalToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontalToolStripButton4.Image")));
            this.flipHorizontalToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipHorizontalToolStripButton4.Name = "flipHorizontalToolStripButton4";
            this.flipHorizontalToolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.flipHorizontalToolStripButton4.Text = "Flip Horizontal";
            this.flipHorizontalToolStripButton4.Click += new System.EventHandler(this.flipHorizontalToolStripButton4_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // rotateLToolStripButton4
            // 
            this.rotateLToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateLToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("rotateLToolStripButton4.Image")));
            this.rotateLToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateLToolStripButton4.Name = "rotateLToolStripButton4";
            this.rotateLToolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.rotateLToolStripButton4.Text = "Rotate Left";
            this.rotateLToolStripButton4.Click += new System.EventHandler(this.rotateLToolStripButton4_Click);
            // 
            // rotateRtoolStripButton4
            // 
            this.rotateRtoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateRtoolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("rotateRtoolStripButton4.Image")));
            this.rotateRtoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateRtoolStripButton4.Name = "rotateRtoolStripButton4";
            this.rotateRtoolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.rotateRtoolStripButton4.Text = "Rotate Right";
            this.rotateRtoolStripButton4.Click += new System.EventHandler(this.rotateRtoolStripButton4_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 530);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // filterPreview1
            // 
            this.filterPreview1.Image = null;
            this.filterPreview1.Location = new System.Drawing.Point(12, 71);
            this.filterPreview1.Name = "filterPreview1";
            this.filterPreview1.Size = new System.Drawing.Size(816, 620);
            this.filterPreview1.TabIndex = 4;
            this.filterPreview1.Text = "filterPreview1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 732);
            this.Controls.Add(this.filterPreview1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pixel It - Main Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton OpenToolBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcHistogram;
        private System.Windows.Forms.ToolStripMenuItem adjustmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private FilterPreview filterPreview1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oilPaintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelEdgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton resizeToolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton zoominToolStripButton4;
        private System.Windows.Forms.ToolStripButton zoomoutToolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton flipVerticalToolStripButton4;
        private System.Windows.Forms.ToolStripButton flipHorizontalToolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton rotateLToolStripButton4;
        private System.Windows.Forms.ToolStripButton rotateRtoolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degToRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInAllFormatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMetaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

