using System;
using System.Drawing;
using System.Windows.Forms;
using wyDay.Controls;


namespace TaxDataStore.Presentation.Controls
{

    public class EmployeesSplitButton : SplitButton
    {

        protected EmployeesMenu ctxMenu;


        public EmployeesSplitButton(EmployeesMenu.ExecutionAction ClickAction)
            : base()
        {
            this.ctxMenu = new EmployeesMenu();
            this.ctxMenu.ClickAction = ClickAction;

            this.TabIndex = 0;
            this.Name = "btnAddEmployee";
            this.Size = new Size(24, 24);
            this.Anchor = AnchorStyles.Left;
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.SplitMenu = this.ctxMenu;
            this.ShowSplit = false;
            this.Image = DomainModel.Application.ResourceManager.GetImage("add");

            this.Click += new EventHandler(EmployeesSplitButton_Click);
        }


        void EmployeesSplitButton_Click(object sender, EventArgs e)
        {
            this.ShowContextMenuStrip();
        }
    
    }
}
