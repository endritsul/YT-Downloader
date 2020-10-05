using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YT_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_download_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(txt_url.Text);
                    File.WriteAllBytes(fbd.SelectedPath + @"/" + video.FullName + ".mp3", await video.GetBytesAsync());
                    MessageBox.Show("Download successivly Completed");
                }
            }
        }
    }
}
