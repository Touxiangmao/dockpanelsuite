using System.Drawing;

namespace WeifenLuo.WinFormsUI.Docking
{
    using ThemeVS2012;
    using ThemeVS2013;

    /// <summary>
    /// Visual Studio 2012 Light theme.
    /// </summary>
    public class VS2012BlueTheme : VS2012ThemeBase
    {
        public VS2012BlueTheme()
            : base(Resources.vs2012blue, new VS2013DockPaneSplitterControlFactory(), new VS2013WindowSplitterControlFactory())
        {
            ColorPalette.TabSelectedInactive.Background = ColorTranslator.FromHtml("#3D5277");// TODO: from theme .FromHtml("#FF4D6082");
        }
    }
}