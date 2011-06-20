using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class HLayoutPanel : TableLayoutPanel
    {

        public HLayoutPanel()
        {
        }

        public HLayoutPanel(string name, int rows, int columns, int tabIndex) :this()
        {
            //this.BackColor = System.Drawing.Color.White;
            this.ColumnCount = columns;
            this.RowCount = rows;
            this.Name = name;
            this.TabIndex = tabIndex;

            this.RightToLeft = RightToLeft.No;
            this.Size = new System.Drawing.Size(50, 50);
            this.Dock = DockStyle.Fill;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new Padding(4);

            for (int i = 0; i < columns; i++)
            {
                this.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < rows; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }


        protected override void OnVisibleChanged(System.EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                if (this.RightToLeft != View.LayoutDirection)
                {
                    this.RightToLeft =
                        View.LayoutDirection;
                }
            }
        }
    }
}
