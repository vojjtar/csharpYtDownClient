
namespace FlaskApiConnect
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.urlInput = new System.Windows.Forms.TextBox();
            this.audioSelectButton = new System.Windows.Forms.Button();
            this.videoSelectDownload = new System.Windows.Forms.Button();
            this.destinationSelectButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.urlStatus = new System.Windows.Forms.Label();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.videoAuthorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadingTextLabel = new System.Windows.Forms.Label();
            this.openPathButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // urlInput
            // 
            this.urlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.urlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlInput.ForeColor = System.Drawing.Color.White;
            this.urlInput.Location = new System.Drawing.Point(12, 12);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(328, 20);
            this.urlInput.TabIndex = 0;
            this.urlInput.TextChanged += new System.EventHandler(this.urlInput_TextChanged);
            // 
            // audioSelectButton
            // 
            this.audioSelectButton.BackColor = System.Drawing.Color.Transparent;
            this.audioSelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.audioSelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.audioSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioSelectButton.ForeColor = System.Drawing.Color.White;
            this.audioSelectButton.Location = new System.Drawing.Point(100, 38);
            this.audioSelectButton.Name = "audioSelectButton";
            this.audioSelectButton.Size = new System.Drawing.Size(90, 30);
            this.audioSelectButton.TabIndex = 1;
            this.audioSelectButton.Text = "MP3";
            this.audioSelectButton.UseVisualStyleBackColor = false;
            this.audioSelectButton.Click += new System.EventHandler(this.audioSelectButton_Click);
            // 
            // videoSelectDownload
            // 
            this.videoSelectDownload.BackColor = System.Drawing.Color.Transparent;
            this.videoSelectDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.videoSelectDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.videoSelectDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoSelectDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoSelectDownload.ForeColor = System.Drawing.Color.White;
            this.videoSelectDownload.Location = new System.Drawing.Point(200, 38);
            this.videoSelectDownload.Name = "videoSelectDownload";
            this.videoSelectDownload.Size = new System.Drawing.Size(90, 30);
            this.videoSelectDownload.TabIndex = 2;
            this.videoSelectDownload.Text = "MP4";
            this.videoSelectDownload.UseVisualStyleBackColor = false;
            this.videoSelectDownload.Click += new System.EventHandler(this.videoSelectDownload_Click);
            // 
            // destinationSelectButton
            // 
            this.destinationSelectButton.BackColor = System.Drawing.Color.Transparent;
            this.destinationSelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.destinationSelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.destinationSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destinationSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationSelectButton.ForeColor = System.Drawing.Color.White;
            this.destinationSelectButton.Location = new System.Drawing.Point(100, 74);
            this.destinationSelectButton.Name = "destinationSelectButton";
            this.destinationSelectButton.Size = new System.Drawing.Size(90, 30);
            this.destinationSelectButton.TabIndex = 3;
            this.destinationSelectButton.Text = "Select Path";
            this.destinationSelectButton.UseVisualStyleBackColor = false;
            this.destinationSelectButton.Click += new System.EventHandler(this.destinationSelectButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(175)))), ((int)(((byte)(57)))));
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(28)))));
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(100, 110);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(190, 30);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "DOWNLOAD";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Location = new System.Drawing.Point(13, 38);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(40, 13);
            this.statusText.TabIndex = 6;
            this.statusText.Text = "API is: ";
            // 
            // urlStatus
            // 
            this.urlStatus.AutoSize = true;
            this.urlStatus.ForeColor = System.Drawing.Color.White;
            this.urlStatus.Location = new System.Drawing.Point(325, 55);
            this.urlStatus.Name = "urlStatus";
            this.urlStatus.Size = new System.Drawing.Size(0, 13);
            this.urlStatus.TabIndex = 8;
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thumbnailBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("thumbnailBox.InitialImage")));
            this.thumbnailBox.Location = new System.Drawing.Point(441, 12);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(163, 92);
            this.thumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailBox.TabIndex = 9;
            this.thumbnailBox.TabStop = false;
            this.thumbnailBox.WaitOnLoad = true;
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.AutoSize = true;
            this.videoNameLabel.ForeColor = System.Drawing.Color.White;
            this.videoNameLabel.Location = new System.Drawing.Point(356, 110);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(16, 13);
            this.videoNameLabel.TabIndex = 10;
            this.videoNameLabel.Text = "...";
            this.videoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoAuthorLabel
            // 
            this.videoAuthorLabel.AutoSize = true;
            this.videoAuthorLabel.ForeColor = System.Drawing.Color.White;
            this.videoAuthorLabel.Location = new System.Drawing.Point(356, 127);
            this.videoAuthorLabel.Name = "videoAuthorLabel";
            this.videoAuthorLabel.Size = new System.Drawing.Size(16, 13);
            this.videoAuthorLabel.TabIndex = 11;
            this.videoAuthorLabel.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author:";
            // 
            // loadingTextLabel
            // 
            this.loadingTextLabel.AutoSize = true;
            this.loadingTextLabel.ForeColor = System.Drawing.Color.White;
            this.loadingTextLabel.Location = new System.Drawing.Point(468, 54);
            this.loadingTextLabel.Name = "loadingTextLabel";
            this.loadingTextLabel.Size = new System.Drawing.Size(0, 13);
            this.loadingTextLabel.TabIndex = 14;
            // 
            // openPathButton
            // 
            this.openPathButton.BackColor = System.Drawing.Color.Transparent;
            this.openPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPathButton.ForeColor = System.Drawing.Color.White;
            this.openPathButton.Location = new System.Drawing.Point(200, 74);
            this.openPathButton.Name = "openPathButton";
            this.openPathButton.Size = new System.Drawing.Size(90, 30);
            this.openPathButton.TabIndex = 15;
            this.openPathButton.Text = "Open Path";
            this.openPathButton.UseVisualStyleBackColor = false;
            this.openPathButton.Click += new System.EventHandler(this.openPathButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(672, 151);
            this.Controls.Add(this.openPathButton);
            this.Controls.Add(this.loadingTextLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoAuthorLabel);
            this.Controls.Add(this.videoNameLabel);
            this.Controls.Add(this.thumbnailBox);
            this.Controls.Add(this.urlStatus);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.destinationSelectButton);
            this.Controls.Add(this.videoSelectDownload);
            this.Controls.Add(this.audioSelectButton);
            this.Controls.Add(this.urlInput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "YoutubeDown";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Button audioSelectButton;
        private System.Windows.Forms.Button videoSelectDownload;
        private System.Windows.Forms.Button destinationSelectButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label urlStatus;
        private System.Windows.Forms.PictureBox thumbnailBox;
        private System.Windows.Forms.Label videoNameLabel;
        private System.Windows.Forms.Label videoAuthorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loadingTextLabel;
        private System.Windows.Forms.Button openPathButton;
    }
}

