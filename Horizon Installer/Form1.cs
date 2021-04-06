using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
namespace Horizon_Installer
{
    public partial class Form1 : Form
    {
        string filename = "Horizon.zip";

        public Form1()
        {
            InitializeComponent();
        }
        string savelocation = @"C:\Users\addik\source\repos\test\";
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("http://hdownload.6te.net/" + filename),
                    // Param2 = Path to save
                    savelocation + filename
                );
            }
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            int progressCompletionAmmount = progressBar1.Maximum / progressBar1.Value;

            if (progressBar1.Maximum == e.ProgressPercentage)
            {
                // do whatever you want to do
            }
        }
    }
}
