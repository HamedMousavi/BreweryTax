using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;


namespace TaxDataStore.Presentation
{
    public class FormControlManager : IDisposable
    {

        protected List<Control> remove;
        protected List<Control> add;

        protected Control controlsOwner;
        protected IEnumerable items;


        public delegate Control CreateControlDelegate(object item);
        public CreateControlDelegate CreateControl { get; set; }

        public delegate Control FindControlDelegate(object item);
        public FindControlDelegate FindControl { get; set; }

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
            this.add.Clear();
            foreach (object item in this.items)
            {
                Control control = FindControl(item);
                if (control != null)
                {
                    this.add.Add(control);
                }
                else
                {
                    this.add.Add(CreateControl(item));
                }
            }

            this.remove.Clear();
            foreach (Control control in this.controlsOwner.Controls)
            {
                if (!this.add.Contains(control))
                {
                    this.remove.Add(control);
                }
            }

            controlsOwner.SuspendLayout();

            foreach (Control control in this.remove)
            {
                this.controlsOwner.Controls.Remove(control);
            }

            this.controlsOwner.Controls.AddRange(this.add.ToArray());

            controlsOwner.ResumeLayout(true);
        }


        public void Dispose()
        {
            
        }

        internal void Reset()
        {
            this.controlsOwner.Controls.Clear();
        }
    }
}
