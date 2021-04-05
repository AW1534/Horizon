using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = false;
            TabRenderer = new ChromeTabRenderer(this);
// Icon = Properties.Resources.Icon1;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content=new frmMain { Text = "New Tab"}
            };
        }
        private void AppContainer_KeyDown(object sender, KeyEventArgs e)
        {
            //frmMain.browser.Load("https://youtube.com");
        }
    }
}
