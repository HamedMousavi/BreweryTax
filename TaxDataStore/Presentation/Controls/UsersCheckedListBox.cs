using System;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class UsersCheckedListBox : CheckedListBox
    {

        public UserCollection SelectedUsers { get; set; }


        public UsersCheckedListBox()
        {
            CheckOnClick = true;
            FormattingEnabled = true;
            Name = "chlbxUsers";
            IntegralHeight = false;
            BorderStyle = BorderStyle.None;
            SelectedUsers = new UserCollection();

            BindData();
        }


        private void BindData()
        {
            DataSource = DomainModel.Membership.Users.GetAll();
            DisplayMember = "Name";
            ValueMember = "Id";
        }


        internal void UpdateBinding()
        {
            BindData();
            MarkSelectedItems();
        }


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible)
            {
                MarkSelectedItems();
            }
        }


        private void MarkSelectedItems()
        {
            if (SelectedUsers == null) return;

            ItemCheck -= OnItemCheck;

            int index = 0;
            UserCollection users = DomainModel.Membership.Users.GetAll();
            foreach (User user in users)
            {
                if (SelectedUsers.Contains(user))
                {
                    SetItemCheckState(index, CheckState.Checked);
                }
                else
                {
                    SetItemCheckState(index, CheckState.Unchecked);
                }

                index++;
            }

            ItemCheck += OnItemCheck;
        }


        protected void OnItemCheck(object sender, ItemCheckEventArgs e)
        {
            User item = (User) Items[e.Index];

            if (item != null)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    SelectedUsers.Add(item);
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    SelectedUsers.Remove(item);
                }
            }
        }
    }
}
