using System.Windows.Forms;
using System.Drawing;


namespace TaxDataStore.Presentation.Controls
{

    public class ContainerLayoutPanel : TableLayoutPanel
    {
        public ContainerLayoutPanel()
            : base()
        {
            this.VisibleChanged += new System.EventHandler(ContainerLayoutPanel_VisibleChanged);
        }


        void ContainerLayoutPanel_VisibleChanged(object sender, System.EventArgs e)
        {
            if (this.Visible)
            {
                if (Presentation.View.Theme != null)
                {
                    if (this.BackColor != Presentation.View.Theme.GroupPanelBackColor)
                    {
                        this.BackColor = Presentation.View.Theme.GroupPanelBackColor;
                    }

                    this.Margin = new Padding(3);
                    this.Padding = new Padding(0);
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
        }
    }
}
