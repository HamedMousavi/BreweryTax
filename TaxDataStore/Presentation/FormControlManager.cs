using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;


namespace TaxDataStore.Presentation
{
    public class FormControlManager
    {

        protected List<Control> remove;
        protected List<Control> add;

        protected Control controlsOwner;
        protected IEnumerable items;


        public delegate Control CreateControlDelegate(object item);
        public CreateControlDelegate CreateControl { get; set; }

        public delegate bool ControlsContainItemDelegate(object item);
        public ControlsContainItemDelegate ControlsContainItem { get; set; }

        public delegate bool ListContainsControlDelegate(UserControl ctrl);
        public ListContainsControlDelegate ListContainsControl { get; set; }


        public FormControlManager(Control controlsOwner, IEnumerable list)
        {
            this.remove = new List<Control>();
            this.add = new List<Control>();

            this.controlsOwner = controlsOwner;
            this.items = list;
        }


        public void Sync()
        {
            this.remove.Clear();
            foreach (UserControl ctrl in this.controlsOwner.Controls)
            {
                if (!ListContainsControl(ctrl))
                {
                    this.remove.Add(ctrl);
                }
            }

            this.add.Clear();
            foreach (object item in this.items)
            {
                if (!ControlsContainItem(item))
                {
                    this.add.Add(CreateControl(item));
                }
            }


            controlsOwner.SuspendLayout();

            foreach (Control ctrl in this.remove)
            {
                this.controlsOwner.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            this.controlsOwner.Controls.AddRange(this.add.ToArray());

            controlsOwner.ResumeLayout(true);
        }

    }
}
