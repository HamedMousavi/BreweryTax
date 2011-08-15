using System.Windows.Forms;
using System.ComponentModel;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class EmployeesMenu : ContextMenuStrip
    {

        protected BindingSource bindingsource;
        
        public delegate void ExecutionAction(string employeeName);
        public ExecutionAction ClickAction { get; set; }


        public EmployeesMenu()
            : base()
        {
            this.bindingsource = new BindingSource();
            this.bindingsource.ListChanged += new 
                ListChangedEventHandler(datasource_ListChanged);

            this.bindingsource.DataSource = DomainModel.Employees.GetAll();
            //this.Click += new System.EventHandler(OnMenuItemClick);
            this.ItemClicked += new ToolStripItemClickedEventHandler(OnItemClicked);
            UpdateItems();
        }


        void datasource_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateItems();
        }


        private void UpdateItems()
        {
            this.Items.Clear();

            foreach (Employee item in (EmployeeCollection)this.bindingsource.DataSource)
            {
                // Add to menu
                this.Items.Add(
                    new System.Windows.Forms.ToolStripMenuItem(
                        item.Name));
            }
        }


        void OnItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != null)
            {
                if (ClickAction != null) ClickAction(e.ClickedItem.Text);
            }
        }
    }
}
