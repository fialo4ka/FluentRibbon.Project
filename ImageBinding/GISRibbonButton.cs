using System.Windows.Data;

namespace ImageBinding
{
    public class GISRibbonButton : Fluent.Button
    {
        public GISRibbonButton()
        {
            var bnd = new Binding("Header")
            {
                RelativeSource = RelativeSource.Self
            };
            SetBinding(ToolTipProperty, bnd);
        }
    }
}
