using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;

namespace FlaskApiConnect
{
    public partial class MainWindow : Form
    {
        bool? video = null;
        string downloadDestination;
        string url;
        string title;

        string defImg = "https://assets.stickpng.com/thumbs/5a461410d099a2ad03f9c998.png";
        string loadingImg = "https://www.advvisioncenters.com/wp-content/uploads/2020/06/loading.gif";

        bool fetcherinoBoolino;

        public MainWindow()
        {
            InitializeComponent();

            thumbnailBox.ImageLocation = defImg;

            bool apiStatus = CheckFetchDownload.ping("http://your.IP");

            if (apiStatus == true)
            {
                statusText.Text = "API is: Online";
            }
            else
            {
                statusText.Text = "API is: Offline";
            }
        }

        private void destinationSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                downloadDestination = browser.SelectedPath;
            }
        }
        private void openPathButton_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(downloadDestination))
            {
                Process.Start(downloadDestination);
            }
            else
            {
                MessageBox.Show("Wrong path");
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(video);

            audioSelectButton.ForeColor = Color.White;
            videoSelectDownload.ForeColor = Color.White;

            url = urlInput.Text;
            title = videoNameLabel.Text;

            Console.WriteLine(url);
            Console.WriteLine(title);

            if (url == string.Empty) MessageBox.Show("url textbox can not be empty.");
            else
            {
                if (System.IO.Directory.Exists(downloadDestination))
                {
                    if (video != null)
                    {
                        System.Threading.Tasks.Task.Factory.StartNew(new Action(() =>
                        {
                            thumbnailBox.ImageLocation = loadingImg;
                            CheckFetchDownload.downloadMedia(url, video, downloadDestination, title);
                            Invoke(new Action(() =>
                            {
                                thumbnailBox.ImageLocation = defImg;
                                videoNameLabel.Text = "...";
                                videoAuthorLabel.Text = "...";
                            }));

                            video = null;
                            fetcherinoBoolino = false;

                        }));

                    }
                    else
                    {
                        MessageBox.Show("You have to choose a file format.");
                    }
                }
                else
                {
                    MessageBox.Show("The path you entered is not valid");
                }
            }
        }

        private void audioSelectButton_Click(object sender, EventArgs e)
        {
            audioSelectButton.ForeColor = Color.Black;
            videoSelectDownload.ForeColor = Color.White;

            video = false;
            Console.WriteLine(video);

            if (fetcherinoBoolino == false)
            {
                fetchInfo();
                fetcherinoBoolino = true;
            }
        }

        private void videoSelectDownload_Click(object sender, EventArgs e)
        {
            videoSelectDownload.ForeColor = Color.Black;
            audioSelectButton.ForeColor = Color.White;

            video = true;
            Console.WriteLine(video);

            if (fetcherinoBoolino == false)
            {
                fetchInfo();
                fetcherinoBoolino = true;
            }

        }

        private void fetchInfo()
        {
            url = urlInput.Text;
            thumbnailBox.ImageLocation = loadingImg;
            //loadingTextLabel.Text = "loading...";


            System.Threading.Tasks.Task.Factory.StartNew(new Action(() =>
            {
                try
                {
                    string json = CheckFetchDownload.fetchInfo(url);

                    dynamic data = JsonConvert.DeserializeObject(json);

                    string thumbnailUrl = data["thumbnail"];
                    string videoName = data["title"];
                    string videoAuthor = data["author"];

                    Invoke(new Action(() =>
                    {
                        thumbnailBox.ImageLocation = thumbnailUrl;
                        videoNameLabel.Text = videoName;
                        videoAuthorLabel.Text = videoAuthor;

                        loadingTextLabel.Text = string.Empty;
                    }));
                }
                catch
                {
                    Console.WriteLine("Wrong url");
                    thumbnailBox.ImageLocation = defImg;
                }

            }));
        }

        private void urlInput_TextChanged(object sender, EventArgs e)
        {
            video = null;
            fetcherinoBoolino = false;
            Console.WriteLine($"MP4: {video} fetcherinoBoolino: {fetcherinoBoolino}");
        }

    }
}
