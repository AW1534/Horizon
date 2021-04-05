using System;
using EasyTabs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    public class TabStyle : BaseTabRenderer
    {
        public TabStyle(TitleBarTabs parentWindow) : base(parentWindow)
        {
            ForeColor = new System.Drawing.Color();
        }
    }
}