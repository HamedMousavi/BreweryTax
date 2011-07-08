using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;


namespace TaxDataStore.Presentation
{

    public class ClientFormManager : IDisposable
    {

        protected Control savedMdiContainer;
        protected Form savedFrmCurrent;


        protected Control frmMDIContainer;
        protected Form frmCurrent;
        protected List<Form> listClientForms;


        public Control Container
        {
            get
            {
                return this.frmMDIContainer;
            }
        }


        public Control SavedContainer
        {
            get
            {
                return this.savedMdiContainer;
            }
        }


        public ClientFormManager()
        {
            this.listClientForms = new List<Form>();
            this.frmCurrent = null;
        }


        public void Attach(Control frmMDIContainer)
        {
            if (this.frmMDIContainer == frmMDIContainer) return;

            // UNwire events
            if (this.frmMDIContainer != null)
            {
                this.frmMDIContainer.SizeChanged -= new
                    EventHandler(frmMDIContainer_SizeChanged);

                // Hide current control
                RemoveCurrentForm();
            }

            // Update container
            this.frmMDIContainer = frmMDIContainer;

            // Wire events
            this.frmMDIContainer.SizeChanged += new
                EventHandler(frmMDIContainer_SizeChanged);
        }


        private void RemoveCurrentForm()
        {
            if (this.frmCurrent != null)
            {
                if (this.frmCurrent.Visible == true)
                {
                    this.frmCurrent.Visible = false;
                }
            }
            this.frmCurrent = null;
        }


        void frmMDIContainer_SizeChanged(object sender, EventArgs e)
        {
            if (this.frmCurrent != null)
            {
                this.frmCurrent.Width = ((Control)sender).Width;
                this.frmCurrent.Height = ((Control)sender).Height;
            }
        }


        public bool AddForm(Form frmClient)
        {
            // cannot add null value to the list
            if (frmClient == null) return false;

            // Form already in list
            if (FindByName(frmClient.Name) != null) return false;

            this.listClientForms.Add(frmClient);
            if (this.frmCurrent == null) SetCurrentForm(frmClient.Name);
            return true;
        }


        public Form SetCurrentForm(string strFormName)
        {
            if (string.IsNullOrWhiteSpace(strFormName)) return null;

            Form frm = FindByName(strFormName);
            if (frm == null) return null;


            // Close previous form
            if (this.frmCurrent != null)
            {
                if (this.frmCurrent.Visible == true)
                {
                    this.frmCurrent.Visible = false;
                }
            }

            // Set current form, but don't display it until user calls DisplayClientForm
            this.frmCurrent = frm;
            return this.frmCurrent;
        }


        public Form FindByName(string strFormName)
        {
            foreach (Form frm in this.listClientForms)
            {
                if (frm != null &&
                     frm.Name.CompareTo(strFormName) == 0)
                {
                    return frm;
                }
            }

            return null;
        }


        // Displays current form on screen
        public bool DisplayClientForm()
        {
            if (this.frmCurrent == null) return false;

            this.frmCurrent.FormBorderStyle = FormBorderStyle.None;
            this.frmCurrent.AutoScroll = true;
            this.frmCurrent.TopLevel = false;

            if (!this.frmMDIContainer.Controls.Contains(this.frmCurrent))
            {
                this.frmMDIContainer.Controls.Add(this.frmCurrent);
            }

            this.frmCurrent.Size = new Size(this.frmMDIContainer.ClientRectangle.Width, this.frmMDIContainer.ClientRectangle.Height);
            this.frmCurrent.Location = this.frmMDIContainer.ClientRectangle.Location;

            // this.frmCurrent.Visible = true;
            this.frmCurrent.Show();
            this.frmCurrent.Focus();

            return true;
        }


        public bool DisplayClientForm(string strFormName)
        {
            if (string.IsNullOrWhiteSpace(strFormName)) return false;

            if (this.frmCurrent == null || this.frmCurrent.Name != strFormName)
            {
                if (SetCurrentForm(strFormName) == null) return false;
            }

            return DisplayClientForm();
        }


        public bool DisplayClientForm(Form frmClient)
        {
            if (frmClient == null) return false;
            if (this.frmCurrent == null || this.frmCurrent != frmClient)
            {
                if (FindByName(frmClient.Name) == null)
                {
                    AddForm(frmClient);
                }

                if (SetCurrentForm(frmClient.Name) == null) return false;
            }

            return DisplayClientForm();
        }


        #region IDisposable Members

        public void Dispose()
        {
            if (this.frmMDIContainer != null)
            {
                this.frmMDIContainer.SizeChanged -= new EventHandler(frmMDIContainer_SizeChanged);
            }

            if (this.listClientForms != null)
            {
                foreach (Form frm in this.listClientForms)
                {
                    if (frm != null)
                    {
                        if (!frm.Disposing)
                        {
                            frm.Close();
                            frm.Dispose();
                        }
                    }
                }

                this.listClientForms.Clear();
                this.listClientForms = null;
            }

            this.frmCurrent = null;
            this.frmMDIContainer = null;
        }

        #endregion


        internal void SaveContainer()
        {
            this.savedMdiContainer = this.frmMDIContainer;
            this.savedFrmCurrent = this.frmCurrent;
        }


        internal void RestoreContainer()
        {
            Attach(this.savedMdiContainer);
            if (this.savedFrmCurrent != null)
            {
                DisplayClientForm(this.savedFrmCurrent);
            }
        }


        internal void SaveCurrentForm()
        {
            this.savedFrmCurrent = this.frmCurrent;
        }


        internal void RestoreCurrentForm()
        {
            if (this.frmCurrent != null)
            {
                this.frmCurrent.Visible = false;
                this.frmCurrent = null;
            }

            if (this.savedFrmCurrent != null)
            {
                DisplayClientForm(this.savedFrmCurrent);
            }
        }


        internal Form DisplayClientForm(string name, Type formType)
        {
            Form form = FindByName(name);

            if (form == null)
            {
                form = (Form)Activator.CreateInstance(formType);
                form.Name = name;
                AddForm(form);
            }

            DisplayClientForm(form);

            return form;
        }
    }
}
