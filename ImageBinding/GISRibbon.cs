using Fluent;
using System.Linq;

namespace ImageBinding
{
    public class GISRibbon : Ribbon
    {
        public RibbonTabItem LastSelectedNonToolTab { get; private set; }
        public GISRibbon()
        {
            SelectedTabChanged += GISRibbon_SelectedTabChanged;
        }

        private void GISRibbon_SelectedTabChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var isOldTabHidden = e.RemovedItems.OfType<RibbonTabItem>().FirstOrDefault()?.Visibility == System.Windows.Visibility.Collapsed;
        }
    }
}
