﻿using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public class UsersListView : ListView
    {
        protected Entities.UserCollection dataSource;
        protected bool resizing = false;
        protected int lastSelectedIndex;


        public UsersListView()
            : base()
        {
            this.BorderStyle = BorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            this.Location = new Point(3, 16);
            this.Name = "lsvUsers";
            this.Size = new Size(184, 418);
            this.TabIndex = 0;
            this.UseCompatibleStateImageBehavior = false;
            this.Visible = true;

            this.View = System.Windows.Forms.View.Details;
            this.MultiSelect = false;
            this.HeaderStyle = ColumnHeaderStyle.None;
            this.HideSelection = false;
            this.FullRowSelect = true;

            this.Columns.Add("Users", this.Width - 5, HorizontalAlignment.Left);
            this.HotTracking = true;

            this.SmallImageList = new ImageList();
            this.SmallImageList.ImageSize = new Size(16, 16);
            this.SmallImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage(
                "user_black_female"));

            this.dataSource = DomainModel.Membership.Users.GetAll();
            this.dataSource.ListChanged += new ListChangedEventHandler(dataSource_ListChanged);

            this.SizeChanged += new System.EventHandler(UsersListView_SizeChanged);
            
            UpdateList();
        }


        void UsersListView_SizeChanged(object sender, System.EventArgs e)
        {
            if (this.resizing) return;
            this.resizing = true;

            this.Columns[0].Width = this.Width - 5;

            this.resizing = false;

        }


        void dataSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateList();
        }


        private void UpdateList()
        {
            this.SuspendLayout();
            /*
            int selected;
            if (this.SelectedIndices != null && 
                this.SelectedIndices.Count > 0)
            {
                selected = this.SelectedIndices[0];
            }
            */
            this.Items.Clear();

            foreach (Entities.User user in this.dataSource)
            {
                ListViewItem item = new ListViewItem();

                item.ImageIndex = 0;
                item.Text = user.Name;

                this.Items.Add(item);
            }

            this.ResumeLayout();
        }


        public Entities.User SelectedUser
        {
            get
            {
                if (this.SelectedItems != null &&
                    this.SelectedItems.Count > 0)
                {
                    int id = this.SelectedItems[0].Index;

                    return dataSource[id];
                }

                return null;
            }
        }


        internal void UpdateView()
        {
            UpdateList();
        }


        public void StoreSelectedIndex()
        {
            if (this.SelectedItems != null &&
                this.SelectedItems.Count > 0)
            {
                this.lastSelectedIndex = this.SelectedItems[0].Index;
            }
        }


        public void RestoreSelectedIndex()
        {
            if (this.lastSelectedIndex > 0 &&
                this.Items.Count <= this.lastSelectedIndex)
            {
                int index = System.Math.Min(this.lastSelectedIndex - 1, this.Items.Count - 1);
                this.Items[index].Selected = true;
            }
            else
            {
                this.Items[this.lastSelectedIndex].Selected = true;
            }
        }


        internal void SelectLastItem()
        {
            if (this.Items.Count > 0)
            {
                this.Items[this.Items.Count - 1].Selected = true;
            }
        }
    }
}
