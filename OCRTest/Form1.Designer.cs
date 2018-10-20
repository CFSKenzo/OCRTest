namespace OCRTest
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
            this.Button_OpenImage = new System.Windows.Forms.Button();
            this.Button_DoOCR = new System.Windows.Forms.Button();
            this.Button_StartStreaming = new System.Windows.Forms.Button();
            this.ComboBox_ImageConvert = new System.Windows.Forms.ComboBox();
            this.Button_StopStreaming = new System.Windows.Forms.Button();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.ZoomPanROIPictureBox_ProcessedImage = new LibUtility.ZoomPanROIPictureBox();
            this.ZoomPanROIPictureBox_OriginalImage = new LibUtility.ZoomPanROIPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_ProcessedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_OriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_OpenImage
            // 
            this.Button_OpenImage.Location = new System.Drawing.Point(12, 401);
            this.Button_OpenImage.Name = "Button_OpenImage";
            this.Button_OpenImage.Size = new System.Drawing.Size(75, 23);
            this.Button_OpenImage.TabIndex = 1;
            this.Button_OpenImage.Text = "Open Image";
            this.Button_OpenImage.UseVisualStyleBackColor = true;
            this.Button_OpenImage.Click += new System.EventHandler(this.Button_OpenImage_Click);
            // 
            // Button_DoOCR
            // 
            this.Button_DoOCR.Location = new System.Drawing.Point(12, 470);
            this.Button_DoOCR.Name = "Button_DoOCR";
            this.Button_DoOCR.Size = new System.Drawing.Size(75, 23);
            this.Button_DoOCR.TabIndex = 1;
            this.Button_DoOCR.Text = "Do OCR";
            this.Button_DoOCR.UseVisualStyleBackColor = true;
            // 
            // Button_StartStreaming
            // 
            this.Button_StartStreaming.Location = new System.Drawing.Point(93, 401);
            this.Button_StartStreaming.Name = "Button_StartStreaming";
            this.Button_StartStreaming.Size = new System.Drawing.Size(97, 23);
            this.Button_StartStreaming.TabIndex = 1;
            this.Button_StartStreaming.Text = "Start Streaming";
            this.Button_StartStreaming.UseVisualStyleBackColor = true;
            this.Button_StartStreaming.Click += new System.EventHandler(this.Button_StartStreaming_Click);
            // 
            // ComboBox_ImageConvert
            // 
            this.ComboBox_ImageConvert.FormattingEnabled = true;
            this.ComboBox_ImageConvert.Location = new System.Drawing.Point(605, 444);
            this.ComboBox_ImageConvert.Name = "ComboBox_ImageConvert";
            this.ComboBox_ImageConvert.Size = new System.Drawing.Size(154, 21);
            this.ComboBox_ImageConvert.TabIndex = 5;
            // 
            // Button_StopStreaming
            // 
            this.Button_StopStreaming.Location = new System.Drawing.Point(93, 430);
            this.Button_StopStreaming.Name = "Button_StopStreaming";
            this.Button_StopStreaming.Size = new System.Drawing.Size(97, 23);
            this.Button_StopStreaming.TabIndex = 1;
            this.Button_StopStreaming.Text = "Stop Streaming";
            this.Button_StopStreaming.UseVisualStyleBackColor = true;
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(793, 33);
            this.TextBox_Result.Multiline = true;
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(435, 354);
            this.TextBox_Result.TabIndex = 6;
            // 
            // ZoomPanROIPictureBox_ProcessedImage
            // 
            this.ZoomPanROIPictureBox_ProcessedImage.Location = new System.Drawing.Point(375, 12);
            this.ZoomPanROIPictureBox_ProcessedImage.Name = "ZoomPanROIPictureBox_ProcessedImage";
            this.ZoomPanROIPictureBox_ProcessedImage.Size = new System.Drawing.Size(357, 375);
            this.ZoomPanROIPictureBox_ProcessedImage.TabIndex = 7;
            this.ZoomPanROIPictureBox_ProcessedImage.TabStop = false;
            // 
            // ZoomPanROIPictureBox_OriginalImage
            // 
            this.ZoomPanROIPictureBox_OriginalImage.Location = new System.Drawing.Point(12, 12);
            this.ZoomPanROIPictureBox_OriginalImage.Name = "ZoomPanROIPictureBox_OriginalImage";
            this.ZoomPanROIPictureBox_OriginalImage.Size = new System.Drawing.Size(357, 375);
            this.ZoomPanROIPictureBox_OriginalImage.TabIndex = 7;
            this.ZoomPanROIPictureBox_OriginalImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 525);
            this.Controls.Add(this.ZoomPanROIPictureBox_ProcessedImage);
            this.Controls.Add(this.ZoomPanROIPictureBox_OriginalImage);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.ComboBox_ImageConvert);
            this.Controls.Add(this.Button_DoOCR);
            this.Controls.Add(this.Button_StopStreaming);
            this.Controls.Add(this.Button_StartStreaming);
            this.Controls.Add(this.Button_OpenImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_ProcessedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomPanROIPictureBox_OriginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OpenImage;
        private System.Windows.Forms.Button Button_DoOCR;
        private System.Windows.Forms.Button Button_StartStreaming;
        private System.Windows.Forms.ComboBox ComboBox_ImageConvert;
        private System.Windows.Forms.Button Button_StopStreaming;
        private System.Windows.Forms.TextBox TextBox_Result;
        private LibUtility.ZoomPanROIPictureBox ZoomPanROIPictureBox_OriginalImage;
        private LibUtility.ZoomPanROIPictureBox ZoomPanROIPictureBox_ProcessedImage;
    }
}

