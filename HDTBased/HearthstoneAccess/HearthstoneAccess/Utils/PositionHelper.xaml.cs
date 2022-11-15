using CoreAPI = Hearthstone_Deck_Tracker.API.Core;
using System.Windows.Controls;

namespace HearthstoneAccess.Utils
{
    /// <summary>
    /// PositionHelper.xaml 的交互逻辑
    /// </summary>
    public partial class PositionHelper : UserControl
    {

        public PositionHelper()
        {
            InitializeComponent();
            CoreAPI.OverlayCanvas.Children.Add(this);
        }
    }
}
