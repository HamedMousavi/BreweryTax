using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class MenuItem : ToolStripMenuItem
    {

        public delegate void ExecutionAction();
        public ExecutionAction ClickAction { get; set; }


        public MenuItem(string name, string imageName, string taskName, ExecutionAction clickAction)
        {
            this.ClickAction = clickAction;
            this.Name = name;
            this.Text = DomainModel.Application.ResourceManager.GetText("mnu_caption_" + this.Name);
            this.ToolTipText = DomainModel.Application.ResourceManager.GetText("mnu_tip_" + this.Name);

            if (!string.IsNullOrEmpty(imageName))
            {
                this.Image = DomainModel.Application.ResourceManager.GetImage(imageName);
            }
            this.RightToLeft = View.LayoutDirection;

            SetVisibility(taskName);

            this.Click += new EventHandler(OnClick);
        }


        private void SetVisibility(string taskName)
        {
            if (string.IsNullOrEmpty(taskName)) return;

            this.Visible = DomainModel.Membership.Users.Authorise(taskName);
        }


        void OnClick(object sender, EventArgs e)
        {
            if (this.ClickAction != null)
            {
                this.ClickAction();
            }
        }
    }
}
