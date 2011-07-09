using System.Windows.Forms;
using System.ComponentModel;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class EmployeesMenu : ContextMenu
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

            UpdateItems();
        }


        void datasource_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateItems();
        }


        private void UpdateItems()
        {
            this.MenuItems.Clear();

            foreach (Employee item in (EmployeeCollection)this.bindingsource.DataSource)
            {
                // Add to menu
                this.MenuItems.Add(
                    new System.Windows.Forms.MenuItem(
                        item.Name,
                        OnMenuItemClick));
            }
        }


        private void OnMenuItemClick(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem menuItem =
                (System.Windows.Forms.MenuItem)sender;

            if (menuItem != null)
            {
                if (ClickAction!= null) ClickAction(menuItem.Text);
            }
        }

    }
}
