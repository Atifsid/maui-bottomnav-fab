using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Platforms.iOS
{
    class CustomShellHandler : ShellRenderer
    {
        protected override IShellItemRenderer CreateShellItemRenderer(ShellItem item)
        {
            return new CustomShellItemRenderer(this)
            {
                ShellItem = item
            };
        }
    }
}
