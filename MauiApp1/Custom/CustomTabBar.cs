using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Maui.BindableProperty.Generator.Core;

namespace MauiApp1.Custom
{
    public partial class CustomTabBar: TabBar
    {
        [AutoBindable]
        private ICommand? centerViewCommand;
        [AutoBindable]
        private ImageSource? centerViewImageSource;
        [AutoBindable]
        private string? centerViewText;
        [AutoBindable]
        private bool centerViewVisible;
        [AutoBindable]
        public Color? centerViewBackgroundColor;
    }
}
