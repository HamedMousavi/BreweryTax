using System;
using System.Drawing;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class WorkbenchItem : UserControl
    {

        public delegate void ExecutionAction();
        public ExecutionAction ClickAction { get; set; }

        
        public WorkbenchItem(string name)
            : base()
        {
            this.SuspendLayout();

            this.Name = name;

            this.BackColor = Color.Transparent;
            this.Dock = DockStyle.Fill;

            this.Cursor = Cursors.Hand;

            Image image = DomainModel.Application.ResourceManager.GetImage(name);
            if (image != null)
            {
                this.Padding = new Padding(0);
                this.Margin = new Padding(0);

                this.ClientSize = new Size(image.Width, image.Height);
                this.MinimumSize = new Size(image.Width, image.Height);
                
                this.BackgroundImage = image;
                this.BackgroundImageLayout = ImageLayout.Zoom;
                this.DoubleBuffered = true;
            }

            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseLeave);
            this.Click += new EventHandler(OnClick);

            this.ResumeLayout(true);
        }


        void OnClick(object sender, EventArgs e)
        {
            if (ClickAction != null)
            {
                ClickAction();
            }
        }


        void OnMouseLeave(object sender, System.EventArgs e)
        {
            DomainModel.Application.Status.Reset();
        }


        void OnMouseEnter(object sender, System.EventArgs e)
        {
            DomainModel.Application.Status.Update(
                StatusController.Abstract.StatusTypes.Info,
                "wbi_desc_" + this.Name);
        }
    }
}
