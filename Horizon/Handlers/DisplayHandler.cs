using CefSharp;
using CefSharp.Enums;
using CefSharp.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Handlers {
    internal class DisplayHandler : IDisplayHandler {
        public void OnAddressChanged(IWebBrowser chromiumWebBrowser, AddressChangedEventArgs addressChangedArgs) {
        }

        public bool OnAutoResize(IWebBrowser chromiumWebBrowser, IBrowser browser, Size newSize) {
            return false;
        }

        public bool OnConsoleMessage(IWebBrowser chromiumWebBrowser, ConsoleMessageEventArgs consoleMessageArgs) {
            return false;
        }

        public bool OnCursorChange(IWebBrowser chromiumWebBrowser, IBrowser browser, IntPtr cursor, CursorType type, CursorInfo customCursorInfo) {
            return false;
        }

        public void OnFaviconUrlChange(IWebBrowser chromiumWebBrowser, IBrowser browser, IList<string> urls) {
            
        }

        public void OnFullscreenModeChange(IWebBrowser browserControl, IBrowser browser, bool fullscreen) {
            Console.WriteLine($"fullscreen: {fullscreen}");
        }

        public void OnLoadingProgressChange(IWebBrowser chromiumWebBrowser, IBrowser browser, double progress) {
            
        }

        public void OnStatusMessage(IWebBrowser chromiumWebBrowser, StatusMessageEventArgs statusMessageArgs) {
            
        }

        public void OnTitleChanged(IWebBrowser chromiumWebBrowser, TitleChangedEventArgs titleChangedArgs) {
            
        }

        public bool OnTooltipChanged(IWebBrowser chromiumWebBrowser, ref string text) {
            return false;
        }
    }
}
