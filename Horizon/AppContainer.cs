using EasyTabs;

namespace Horizon {
    public partial class AppContainer : TitleBarTabs {
        public AppContainer() {
            InitializeComponent();
            AeroPeekEnabled = false;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Properties.Resources.Logo;
        }

        public override TitleBarTab CreateTab() {
            return new TitleBarTab(this) {
                Content = new FrmMain { Text = "New Tab" }
            };
        }
    }
}
