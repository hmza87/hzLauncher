using hzLauncher.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hzLauncher.Views
{
    public partial class LauncherView : Form
    {
        public virtual bool init(List<ShortCut> Shorts)
        {
            return false;
        }
    }
}
