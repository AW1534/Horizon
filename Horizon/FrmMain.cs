using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace Horizon {
    public partial class FrmMain : Form {
        ChromiumWebBrowser browser;
        Uri newTabUrl = new Uri("file://" + App.newTabPage);

        public FrmMain(ChromiumWebBrowser browser = null) {
            this.browser = browser;
        }

        public FrmMain() {
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e) {
            if (browser == null) {
                browser = new ChromiumWebBrowser(newTabUrl.ToString());
            }

            browser.DownloadHandler = App.downloadHandler;
            browser.RequestHandler = App.requestHandler;

            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);

            this.Icon = Properties.Resources.Logo;

            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += browser_TitleChanged;

            this.Invoke(new Action(() => {
                btnBack.Enabled = browser.CanGoBack;
                btnFwd.Enabled = browser.CanGoForward;
            }));
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e) {
            if (e.Address.ToString().ToLower() == newTabUrl.ToString().ToLower()) {
                this.Invoke(new Action(() => {
                    txtUrl.Focus();
                }));
            }
            else {
                this.BeginInvoke(new MethodInvoker(() => {
                    txtUrl.Text = e.Address.ToString();
                }));
            }
        }

        public void favicon() {
            try {
                // TODO: Load any file even if it isnt located at /favicon.ico (get from metadata)
                Uri url = new Uri("https://" + new Uri(browser.Address).Host + "/favicon.ico");
                Icon img = new Icon(new System.IO.MemoryStream(new
                WebClient().DownloadData(url)));
                this.Invoke(new MethodInvoker(() => {
                    this.Icon = img;
                }));
            }
            catch (Exception) {
                this.Invoke(new MethodInvoker(() => {
                    this.Icon =  Properties.Resources.Logo;
                }));
                //change tempIcon to your desired icon, extension is .ico 
            }
        }

        private void browser_TitleChanged(Object sender, TitleChangedEventArgs e) {
            Thread t = new Thread(new ThreadStart(favicon)); t.Start();
            this.BeginInvoke(new MethodInvoker(() => {
                this.Text = e.Title;
            }));
            this.Invoke(new Action(() => {
                btnBack.Enabled = browser.CanGoBack;
                btnFwd.Enabled = browser.CanGoForward;
            }));
        }

        private void go(object sender, EventArgs e) {
            String text = txtUrl.Text;

            if (App.isUrl(text)) {

                text = App.FixUrl(text);
            }
            else {
                text = App.horizonSettings.engine.url.Replace("$(query)", text);
                Console.WriteLine(text);
            }

            browser.Load(text);
        }



        private void FrmMain_KeyDown(object sender, KeyEventArgs e) {

        }

        private void txtUrl_KeyPress(object sender, KeyEventArgs e) {
            if (e.KeyValue == (char)13) {
                pContainer.Focus();
                go(sender, e);
            }
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e) {

        }

        private void TxtUrl_Enter(object sender, System.EventArgs e) {
            //Dispatcher.InvokeAsync((sender as TextBox).SelectAll);
        }

        private void TxtUrl_GotFocus(object sender, System.EventArgs e) {
            // txtUrl.SelectAll();
        }

        private void txtUrl_TextChanged_1(object sender, EventArgs e) {

        }

        private void btnBack_Click(object sender, EventArgs e) {
            if (browser.CanGoBack) {
                browser.Back();
            }

            this.Invoke(new Action(() => {
                btnBack.Enabled = browser.CanGoBack;
            }));
        }

        private void btnFwd_Click(object sender, EventArgs e) {
            if (browser.CanGoForward) {
                browser.Forward();
            }

            this.Invoke(new Action(() => {
                btnBack.Enabled = browser.CanGoForward;
            }));
        }

        private void btnRld_Click(object sender, EventArgs e) {
            browser.Reload();
        }
    }
}
