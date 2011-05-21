using System;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class TasksCheckedListBox : CheckedListBox
    {

        public Entities.Role Role { get; set; }
        protected bool checking;


        public TasksCheckedListBox()
        {
            this.checking = false;

            this.CheckOnClick = true;
            this.FormattingEnabled = true;
            this.Name = "chlbxTasks";
            this.IntegralHeight = false;
            this.BorderStyle = BorderStyle.None;

            BindData();
        }


        private void BindData()
        {
            this.DataSource = DomainModel.Membership.Tasks.GetAll();
            this.DisplayMember = "Name";
            this.ValueMember = "Id";
        }


        internal void UpdateBinding()
        {
            BindData();
            MarkSelectedItems();
        }


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                MarkSelectedItems();
            }
        }


        private void MarkSelectedItems()
        {
            if (this.Role == null) return;

            this.ItemCheck -= new ItemCheckEventHandler(OnItemCheck);

            int index = 0;
            TaskCollection tasks = DomainModel.Membership.Tasks.GetAll();
            foreach (Task task in tasks)
            {
                if (this.Role.Tasks.Contains(task))
                {
                    SetItemCheckState(index, CheckState.Checked);
                }
                else
                {
                    SetItemCheckState(index, CheckState.Unchecked);
                }

                index++;
            }

            this.ItemCheck += new ItemCheckEventHandler(OnItemCheck);
        }


        protected void OnItemCheck(object sender, ItemCheckEventArgs e)
        {
            Task item = (Task)this.Items[e.Index];

            if (item != null)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (DomainModel.Membership.Roles.AddTaskToRole(this.Role, item))
                    {
                        this.Role.Tasks.Add(item);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    if (DomainModel.Membership.Roles.RemoveTaskFromRole(this.Role, item))
                    {
                        this.Role.Tasks.Remove(item);
                    }
                }
            }
        }
    }
}
