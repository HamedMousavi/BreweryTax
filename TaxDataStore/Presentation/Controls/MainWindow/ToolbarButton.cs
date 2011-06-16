using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class ToolbarButton : ToolStripButton
    {

        public delegate void ExecutionAction();
        public ExecutionAction ClickAction { get; set; }


        public ToolbarButton(string name, string imageName, string taskName, ExecutionAction clickAction)
        {
            this.Name = name;
            this.ClickAction = clickAction;

            this.Size = new System.Drawing.Size(23, 22);
            this.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.TextImageRelation = TextImageRelation.ImageBeforeText;

            this.Text = DomainModel.Application.ResourceManager.GetText("mnu_caption_" + this.Name);
            this.ToolTipText = DomainModel.Application.ResourceManager.GetText("mnu_tip_" + this.Name);

            this.RightToLeft = View.LayoutDirection;

            if (!string.IsNullOrWhiteSpace(imageName))
            {
                this.Image = DomainModel.Application.ResourceManager.GetImage(imageName);
            }


            SetVisibility(taskName);

            this.Click += new EventHandler(OnClick);
        }


        private void SetVisibility(string taskName)
        {
            if (string.IsNullOrWhiteSpace(taskName)) return;

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
