namespace ImageEdgeDetection
{
    partial class MainForm
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.checkBoxSwap = new System.Windows.Forms.CheckBox();
            this.checkBoxCrazy = new System.Windows.Forms.CheckBox();
            this.labelDetection = new System.Windows.Forms.Label();
            this.flowLayoutPanelCheckBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.flowLayoutPanelCheckBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(651, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 618);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(150, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(513, 618);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(150, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetection.Enabled = false;
            this.cmbEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(195, 676);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(312, 37);
            this.cmbEdgeDetection.TabIndex = 20;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.NeighbourCountValueChangedEventHandler);
            // 
            // checkBoxSwap
            // 
            this.checkBoxSwap.AutoSize = true;
            this.checkBoxSwap.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSwap.Name = "checkBoxSwap";
            this.checkBoxSwap.Size = new System.Drawing.Size(99, 21);
            this.checkBoxSwap.TabIndex = 21;
            this.checkBoxSwap.Text = "Swap Filter";
            this.checkBoxSwap.UseVisualStyleBackColor = true;
            this.checkBoxSwap.CheckedChanged += new System.EventHandler(this.checkBoxSwap_CheckedChanged);
            // 
            // checkBoxCrazy
            // 
            this.checkBoxCrazy.AutoSize = true;
            this.checkBoxCrazy.Location = new System.Drawing.Point(108, 3);
            this.checkBoxCrazy.Name = "checkBoxCrazy";
            this.checkBoxCrazy.Size = new System.Drawing.Size(101, 21);
            this.checkBoxCrazy.TabIndex = 21;
            this.checkBoxCrazy.Text = "Crazy Filter";
            this.checkBoxCrazy.UseVisualStyleBackColor = true;
            this.checkBoxCrazy.CheckedChanged += new System.EventHandler(this.checkBoxCrazy_CheckedChanged);
            // 
            // labelDetection
            // 
            this.labelDetection.AutoSize = true;
            this.labelDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labelDetection.Location = new System.Drawing.Point(9, 689);
            this.labelDetection.Name = "labelDetection";
            this.labelDetection.Size = new System.Drawing.Size(180, 17);
            this.labelDetection.TabIndex = 22;
            this.labelDetection.Text = "Edge detection method:";
            // 
            // flowLayoutPanelCheckBoxes
            // 
            this.flowLayoutPanelCheckBoxes.Controls.Add(this.checkBoxSwap);
            this.flowLayoutPanelCheckBoxes.Controls.Add(this.checkBoxCrazy);
            this.flowLayoutPanelCheckBoxes.Enabled = false;
            this.flowLayoutPanelCheckBoxes.Location = new System.Drawing.Point(168, 624);
            this.flowLayoutPanelCheckBoxes.Name = "flowLayoutPanelCheckBoxes";
            this.flowLayoutPanelCheckBoxes.Size = new System.Drawing.Size(339, 40);
            this.flowLayoutPanelCheckBoxes.TabIndex = 0;
            // 
            // btnClearImage
            // 
            this.btnClearImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClearImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearImage.Location = new System.Drawing.Point(513, 676);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(150, 39);
            this.btnClearImage.TabIndex = 23;
            this.btnClearImage.Text = "Clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(675, 727);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.flowLayoutPanelCheckBoxes);
            this.Controls.Add(this.labelDetection);
            this.Controls.Add(this.cmbEdgeDetection);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.flowLayoutPanelCheckBoxes.ResumeLayout(false);
            this.flowLayoutPanelCheckBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.CheckBox checkBoxSwap;
        private System.Windows.Forms.CheckBox checkBoxCrazy;
        private System.Windows.Forms.Label labelDetection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCheckBoxes;
        private System.Windows.Forms.Button btnClearImage;
    }
}

