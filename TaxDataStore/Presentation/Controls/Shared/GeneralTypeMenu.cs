using System.ComponentModel;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class GeneralTypeMenu : ContextMenuStrip
    {
        
        protected Entities.GeneralTypeCollection items;


        public delegate void ExecutionAction(Entities.GeneralType item);
        public ExecutionAction ClickAction { get; set; }

        
        public GeneralTypeMenu(Entities.GeneralTypeCollection items)
        {
            this.items = items;
            this.items.ListChanged += new 
                ListChangedEventHandler(bindingsource_ListChanged);
            UpdateData();

            this.ItemClicked += new 
                ToolStripItemClickedEventHandler(
                    SignupTypeMenu_ItemClicked);
        }


        void bindingsource_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateData();
        }


        private void UpdateData()
        {
            this.Items.Clear();
            foreach (Entities.GeneralType type in this.items)
            {
                this.Items.Add(new GeneralTypeToolStripItem(type));
            }
        }


        void SignupTypeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            GeneralTypeToolStripItem item =
                (GeneralTypeToolStripItem)e.ClickedItem;

            if (item != null)
            {
                if (ClickAction != null) ClickAction(item.GeneralType);
            }
        }
    }
}
