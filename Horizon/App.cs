using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using Horizon.Handlers;
using Syroot.Windows.IO;
using System;
using System.IO;
using System.Windows.Forms;

namespace Horizon {
    internal static class App {
        [Serializable]
        public class engine {
            public string name = "";
            public string url = "";

            public engine(string name, string url) {
                this.name = name;
                this.url = url;
            }
        }

        [Serializable]
        public static class engines {
            // Available search engines (In future, custom engines will be allowed)
            public static engine BING       = new engine("Bing",       "https://www.bing.com/search?q=$(query)");
            public static engine DUCKDUCKGO = new engine("DuckDuckGo", "https://duckduckgo.com/?q=$(query)");
            public static engine ECOSIA     = new engine("Ecosia",     "https://www.ecosia.org/search?q=$(query)");
            public static engine GOOGLE     = new engine("Google",     "https://google.com/search?q=$(query)");

            // You have no reason to use the following ones but...
            public static engine YOUTUBE    = new engine("YouTube",    "https://youtube.com/search?q=$(query)");
        }

        [Serializable]
        internal static class horizonSettings  {
            public static engine engine = engines.DUCKDUCKGO;
            public static string downloadPath = new KnownFolder(KnownFolderType.Downloads).Path;
        }

        public static string dir;
        public static string newTabPage;
        public static CefSettings cefSettings = new CefSettings();
        public static IDownloadHandler downloadHandler = new DownloadHandler();
        public static string appPath = new KnownFolder(KnownFolderType.RoamingAppData).Path + "/Horizon/";

        [STAThread]
        static void Main() {
            dir = Directory.GetCurrentDirectory();
            newTabPage = appPath + "/IncludeFiles/Pages/NewTab.html";
            Console.WriteLine(newTabPage);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CefSharpSettings.ShutdownOnExit = false;

            cefSettings.CachePath = dir + "/cache";
            cefSettings.EnablePrintPreview();
            cefSettings.RegisterScheme(new CefCustomScheme {
                SchemeName = "horizon",
                SchemeHandlerFactory = new Handlers.SchemeHandlerFactory()
            });

            Cef.Initialize(cefSettings);

            AppContainer container = new AppContainer();
            container.Tabs.Add(new EasyTabs.TitleBarTab(container) {
                Content = new FrmMain {
                    Text = "New Tab",
                    Dock = DockStyle.Fill
                }
            });
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);

            Cef.Shutdown();
        }

        public static bool isUrl(String text) {
            return (text.Contains(".") || text.Contains("://")) && !text.Contains(" ");
        }

        public static String FixUrl(String text, bool trim = true) {
            if (trim) {
                text = text.Trim();
            }

            if (!text.Contains(":")) {
                text = "https://" + text;
            }

            return text;
        }
    }
}
