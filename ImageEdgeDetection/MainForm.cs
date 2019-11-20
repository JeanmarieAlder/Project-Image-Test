/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEdgeDetection
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbEdgeDetection.SelectedIndex = 0;
        }



        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                setPreviewPic(previewBitmap);

                ApplyFilterEdge(true);
            }

            //Handle input state change if needed
            handleInputStateChange();
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            ApplyFilterEdge(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                }
            }
        }

        private void ApplyFilterEdge(bool preview)
        {
            if (previewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource;
            Bitmap resultEdgeFilter = null;

            if (preview == true)
            {
                selectedSource = previewBitmap;
            }
            else
            {
                selectedSource = resultBitmap;
            }

            // Apply the different edge filters
            if (selectedSource != null)
            {
                if (cmbEdgeDetection.SelectedItem.ToString() == "None")
                {
                    resultEdgeFilter = selectedSource;
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3")
                {
                    resultEdgeFilter = selectedSource.Laplacian3x3Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 Grayscale")
                {
                    resultEdgeFilter = selectedSource.Laplacian3x3Filter(true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5")
                {
                    resultEdgeFilter = selectedSource.Laplacian5x5Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 Grayscale")
                {
                    resultEdgeFilter = selectedSource.Laplacian5x5Filter(true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian of Gaussian")
                {
                    resultEdgeFilter = selectedSource.LaplacianOfGaussianFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 3x3")
                {
                    resultEdgeFilter = selectedSource.Laplacian3x3OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 1")
                {
                    resultEdgeFilter = selectedSource.Laplacian3x3OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 2")
                {
                    resultEdgeFilter = selectedSource.Laplacian3x3OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 3x3")
                {
                    resultEdgeFilter = selectedSource.Laplacian5x5OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 1")
                {
                    resultEdgeFilter = selectedSource.Laplacian5x5OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 2")
                {
                    resultEdgeFilter = selectedSource.Laplacian5x5OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3")
                {
                    resultEdgeFilter = selectedSource.Sobel3x3Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3 Grayscale")
                {
                    resultEdgeFilter = selectedSource.Sobel3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt")
                {
                    resultEdgeFilter = selectedSource.PrewittFilter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt Grayscale")
                {
                    resultEdgeFilter = selectedSource.PrewittFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch")
                {
                    resultEdgeFilter = selectedSource.KirschFilter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch Grayscale")
                {
                    resultEdgeFilter = selectedSource.KirschFilter();
                }
            }

            if (resultEdgeFilter != null)
            {
                if (preview == true)
                {
                    setPreviewPic(resultEdgeFilter);
                }
                else
                {
                    resultBitmap = resultEdgeFilter;
                }
            }
        }

        /// <summary>
        /// Resets all settings and clear image.
        /// Called when the button "Clear" is pressed
        /// </summary>
        private void resetAll()
        {
            originalBitmap = null;
            previewBitmap = null;
            setPreviewPic(null);
            cmbEdgeDetection.SelectedItem = "None"; //default value is None
            crazyFilterCheckBox.Checked = false;
            swapFilterCheckBox.Checked = false;
        }

        /// <summary>
        /// Method that deals with input state changes
        /// and enable / disable inputs when needed.
        /// </summary>
        private void handleInputStateChange()
        {
            //check to enable edge detection
            if ((crazyFilterCheckBox.Checked || swapFilterCheckBox.Checked) && originalBitmap != null)
            {
                //Edge detection only avaliable if at least one filter is selected
                //and if an image has been uploaded.
                cmbEdgeDetection.Enabled = true;
            }
            else
            {
                cmbEdgeDetection.Enabled = false;
            }

            //check to enable filters
            if (cmbEdgeDetection.SelectedItem.ToString() != "None" || originalBitmap == null)
            {
                //Change filter only avaliable if no edge detection is enabled
                flowLayoutPanelCheckBoxes.Enabled = false;
            }
            else
            {
                //Change filter is avaliable is no edge detection is enabled
                flowLayoutPanelCheckBoxes.Enabled = true;
            }
        }

        private void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilterEdge(true);
            handleInputStateChange();
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            //When "Clear" is pressed, reset image and settings and
            //handle input state.
            resetAll();
            handleInputStateChange();
        }

        private void swapFilter_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox to activate Swap Filter
            handleInputStateChange();
            //put the filters which are checked
            applyfilters();
        }

        private void crazyFilter_CheckedChanged(object sender, EventArgs e)
        {
            //Checkbox to activate Crazy filter
            handleInputStateChange();
            //put the filters which are checked
            applyfilters();
        }

        private void applyfilters()
        {
            Bitmap temp = originalBitmap;
            if (temp != null)
            {
                if (swapFilterCheckBox.Checked)
                {
                    temp = ImageFilters.ApplyFilterSwap(new Bitmap(temp));
                }
                if (crazyFilterCheckBox.Checked)
                {
                    temp = ImageFilters.ApplyFilterSwapDivide(new Bitmap(temp), 1, 1, 2, 1);
                    temp = ImageFilters.ApplyFilterSwap(new Bitmap(temp));
                }

                setPreviewPic(temp);
                resultBitmap = temp;
                previewBitmap = temp;
            }

        }

        private void setPreviewPic(Bitmap imgToDisplay)
        {
            picPreview.Image = imgToDisplay;
        }

    }
}
