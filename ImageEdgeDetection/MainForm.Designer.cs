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
            this.labelDetection = new System.Windows.Forms.Label();
            this.flowLayoutPanelCheckBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.swapFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.crazyFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.picPreview.Size = new System.Drawing.Size(668, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(31, 619);
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
            this.btnSaveNewImage.Location = new System.Drawing.Point(530, 618);
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
            this.cmbEdgeDetection.Location = new System.Drawing.Point(212, 676);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(312, 37);
            this.cmbEdgeDetection.TabIndex = 20;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.NeighbourCountValueChangedEventHandler);
            // 
            // labelDetection
            // 
            this.labelDetection.AutoSize = true;
            this.labelDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labelDetection.Location = new System.Drawing.Point(28, 689);
            this.labelDetection.Name = "labelDetection";
            this.labelDetection.Size = new System.Drawing.Size(180, 17);
            this.labelDetection.TabIndex = 22;
            this.labelDetection.Text = "Edge detection method:";
            // 
            // flowLayoutPanelCheckBoxes
            // 
            this.flowLayoutPanelCheckBoxes.Controls.Add(this.swapFilterCheckBox);
            this.flowLayoutPanelCheckBoxes.Controls.Add(this.crazyFilterCheckBox);
            this.flowLayoutPanelCheckBoxes.Enabled = false;
            this.flowLayoutPanelCheckBoxes.Location = new System.Drawing.Point(247, 635);
            this.flowLayoutPanelCheckBoxes.Name = "flowLayoutPanelCheckBoxes";
            this.flowLayoutPanelCheckBoxes.Size = new System.Drawing.Size(216, 29);
            this.flowLayoutPanelCheckBoxes.TabIndex = 0;
            // 
            // swapFilterCheckBox
            // 
            this.swapFilterCheckBox.AutoSize = true;
            this.swapFilterCheckBox.Location = new System.Drawing.Point(3, 3);
            this.swapFilterCheckBox.Name = "swapFilterCheckBox";
            this.swapFilterCheckBox.Size = new System.Drawing.Size(99, 21);
            this.swapFilterCheckBox.TabIndex = 26;
            this.swapFilterCheckBox.Text = "Swap Filter";
            this.swapFilterCheckBox.UseVisualStyleBackColor = true;
            this.swapFilterCheckBox.CheckedChanged += new System.EventHandler(this.swapFilter_CheckedChanged);
            // 
            // crazyFilterCheckBox
            // 
            this.crazyFilterCheckBox.AutoSize = true;
            this.crazyFilterCheckBox.Location = new System.Drawing.Point(108, 3);
            this.crazyFilterCheckBox.Name = "crazyFilterCheckBox";
            this.crazyFilterCheckBox.Size = new System.Drawing.Size(101, 21);
            this.crazyFilterCheckBox.TabIndex = 25;
            this.crazyFilterCheckBox.Text = "Crazy Filter";
            this.crazyFilterCheckBox.UseVisualStyleBackColor = true;
            this.crazyFilterCheckBox.CheckedChanged += new System.EventHandler(this.crazyFilter_CheckedChanged);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnClearImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearImage.Location = new System.Drawing.Point(530, 676);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(150, 39);
            this.btnClearImage.TabIndex = 23;
            this.btnClearImage.Text = "Clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "3)";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(692, 731);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label labelDetection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCheckBoxes;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.CheckBox crazyFilterCheckBox;
        private System.Windows.Forms.CheckBox swapFilterCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

