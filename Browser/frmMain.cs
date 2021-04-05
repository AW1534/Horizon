using EasyTabs;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Net;

namespace Horizon
{
    public partial class frmMain : Form
    {
        static public DiscordRpcClient client;

        CefSettings settings = new CefSettings();
        public ChromiumWebBrowser browser;
        static bool Initialised = false;

        string CurrAdress;
        string CurrTitle;

        static string DefPath = @".cushion";
        static string NewTabPage;
        static string Path;

        bool ThemeMenuVisible = true;

        HttpWebResponse response;

        public frmMain()
        {
            InitializeComponent();
            if (Initialised != true)
            {
                client = new DiscordRpcClient("825173580638715964");

                //Set the logger
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

                //Subscribe to events
                client.OnReady += (sender, e) =>
                {
                    Console.WriteLine("Received Ready from user {0}", e.User.Username);
                };

                client.OnPresenceUpdate += (sender, e) =>
                {
                    Console.WriteLine("Received Update! {0}", e.Presence);
                };

                //Connect to the RPC
                client.Initialize();

                string TempPath = Directory.GetParent(DefPath).FullName;


                Path = System.IO.Path.Combine(TempPath, "CefSharp.BrowserSubprocess.exe");

                Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
                Initialised = true;

                NewTabPage = System.IO.Path.Combine(TempPath, "Pages/NewTab.html");

                this.AcceptButton = btnGo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;

            browser.Load(url);
        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            browser.Load("https://youtube.com");
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.T)
            {
                
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(NewTabPage);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);

            browser.Load(NewTabPage);


            browser.MenuHandler = new MyCustomMenuHandler();

          

            browser.AddressChanged += Browser_AddressChanged;
           browser.TitleChanged += Browser_TitleChanged;
        }
        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                CurrAdress = e.Address;
                if (e.Address != NewTabPage)
                {
                    txtUrl.Text = e.Address;
                }
                client.SetPresence(new RichPresence()
                {
                    //Details = CurrTitle.Length > 31 ? CurrTitle.Substring(0, 31) : CurrTitle,
                    State = CurrAdress.Length > 31 ? CurrAdress.Substring(0, 28) + "..." : CurrAdress,
                    Assets = new Assets()
                    {
                        LargeImageKey = "image_large", 
                        LargeImageText = "",
                        SmallImageKey = "image_small",   
                    },
                });
                    client.SetPresence(new RichPresence()
                    {
                        State = CurrAdress.Length > 31 ? CurrAdress.Substring(0, 28) + "..." : CurrAdress,
                        Assets = new Assets()
                        {
                            LargeImageKey = "image_large",
                            LargeImageText = "",
                            SmallImageKey = "image_small",
                        }
                    });
            }));
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            CurrTitle = e.Title;
            client.SetPresence(new RichPresence()
            {
                Details = CurrTitle.Length > 31 ? CurrTitle.Substring(0, 28) + "..." : CurrTitle,
                State = CurrAdress.Length > 31 ? CurrAdress.Substring(0, 28) + "..." : CurrAdress,
                Assets = new Assets()
                {
                    LargeImageKey = "image_large",
                    LargeImageText = "",
                    SmallImageKey = "image_small"
                }
            }); ;
            //this.AppContainer
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (isUrlValid(txtUrl.Text) == true)
            {
                browser.Load(CurrAdress);
            }
        }
         private void Back_Click(object sender, EventArgs e)
         {
            //if (Sites[(s-1)] != null)
            //{
            //    browser.Load(Sites[s]);
            //    s--;
            //}
            if (browser.CanGoBack == true)
            {
                browser.Back();
            }
         }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward == true)
            {
                browser.Forward();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Theme_Click(object sender, EventArgs e)
        {
            ThemeMenuToggle();
        }
        public void ThemeMenuToggle()
        {
            if (ThemeMenuVisible == false)
            {
                this.ThemeSelector.Visible = true;
                ThemeMenuVisible = true;
            }
            else if (ThemeMenuVisible == true)
            {
                this.ThemeSelector.Visible = false;
                ThemeMenuVisible = false;
            }
        }
        public bool isUrlValid(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                __dispose(ex.ToString());
                return false;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void __dispose(String _) { }
    }
}
