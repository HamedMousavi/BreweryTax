using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{
    public class FlatButton : Button
    {
        public FlatButton()
            : base()
        {
            this.VisibleChanged += new EventHandler(FlatButton_VisibleChanged);
        }


        void FlatButton_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && Presentation.View.Theme != null)
            {
                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowOnly;
                this.FlatStyle = FlatStyle.Flat;
                
                this.Margin = new Padding(3);
                this.Padding = new Padding(0);

                this.Size = new System.Drawing.Size(26, 26);
                this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
                this.TextImageRelation = TextImageRelation.ImageBeforeText;
                this.UseVisualStyleBackColor = false;

                this.BackColor = Presentation.View.Theme.FlatButtonBackColor;
                this.FlatAppearance.BorderColor = Presentation.View.Theme.FlatButtonBorderColor;
                this.ForeColor = Presentation.View.Theme.FlatButtonForeColor;
                this.Anchor = AnchorStyles.Left;
            }
        }
    }
}
