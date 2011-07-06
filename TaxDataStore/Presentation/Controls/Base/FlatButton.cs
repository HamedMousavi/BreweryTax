using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{
    public class FlatButton : Button
    {
        public FlatButton(int tabIndex, string name, string imageName, string textName)
            : base()
        {
            if (Presentation.View.Theme != null)
            {
                this.SuspendLayout();

                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowOnly;
                this.FlatStyle = FlatStyle.Flat;

                this.Margin = new Padding(2, 2, 2, 2);
                this.Padding = new Padding(0, 0, 3, 1);

                this.Size = new System.Drawing.Size(10, 10);
                this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.TextImageRelation = TextImageRelation.ImageBeforeText;
                this.UseVisualStyleBackColor = false;

                this.BackColor = System.Drawing.Color.Transparent;
                this.FlatAppearance.BorderColor = Presentation.View.Theme.FlatButtonBorderColor;
                this.ForeColor = Presentation.View.Theme.FlatButtonForeColor;
                this.Anchor = AnchorStyles.Left;
            }
            
            if (DomainModel.Application.ResourceManager != null)
            {
                if (!string.IsNullOrWhiteSpace(textName))
                {
                    this.Text = DomainModel.Application.ResourceManager.GetText(textName);

                    if (string.IsNullOrWhiteSpace(this.Text))
                    {
                        this.Text = textName;
                    }
                }

                if (!string.IsNullOrWhiteSpace(imageName))
                {
                    this.Image = DomainModel.Application.ResourceManager.GetImage(imageName);
                }
            }

            this.Name = name;
            this.TabIndex = tabIndex;

            this.ResumeLayout(true);

        }
    }
}
