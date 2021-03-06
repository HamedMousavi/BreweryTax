﻿using System;
using System.Windows.Forms;
using Entities;

namespace TaxDataStore.Presentation.Controls
{

    public class TasksCheckedListBox : CheckedListBox
    {

        public Role Role { get; set; }


        public TasksCheckedListBox()
        {
            CheckOnClick = true;
            FormattingEnabled = true;
            Name = "chlbxTasks";
            IntegralHeight = false;
            BorderStyle = BorderStyle.None;

            BindData();
        }


        private void BindData()
        {
            DataSource = DomainModel.Membership.Tasks.GetAll();
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
            if (Role == null) return;

            ItemCheck -= OnItemCheck;

            int index = 0;
            TaskCollection tasks = DomainModel.Membership.Tasks.GetAll();
            foreach (Task task in tasks)
            {
                if (Role.Tasks.Contains(task))
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
            Task item = (Task)Items[e.Index];

            if (item != null)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (DomainModel.Membership.Roles.AddTaskToRole(Role, item))
                    {
                        Role.Tasks.Add(item);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    if (DomainModel.Membership.Roles.RemoveTaskFromRole(Role, item))
                    {
                        Role.Tasks.Remove(item);
                    }
                }
            }
        }
    }
}
