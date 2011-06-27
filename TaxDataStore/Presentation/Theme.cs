using System.Drawing;

namespace TaxDataStore.Presentation
{
    public class Theme
    {
        public Color ToolBarBackColor { get; set; }
        public Color ToolBarForeColor { get; set; }
        public Font ToolBarFont { get; set; }

        public Color GroupPanelBackColor { get; set; }

        public Color FlatButtonBackColor { get; set; }
        public Color FlatButtonBorderColor { get; set; }
        public Color FlatButtonForeColor { get; set; }

        public Font GroupPanelTitleFont { get; set; }
        public Color GroupPanelTitleColor { get; set; }

        public Font FormFont { get; set; }
        public Font FormLabelFont { get; set; }

        public Color FormLabelColor { get; set; }
        public Color FormBackColor { get; set; }

        public Color FormLightLabelColor { get; set; }
        public Color FormLightBackColor { get; set; }


        public Theme()
        {
            //(255, 210, 225, 245);
            // 255, 195, 205, 225
            //Color.FromArgb(255, 233, 236, 240);

            this.GroupPanelBackColor = Color.FromArgb(255, 233, 236, 240);
            this.GroupPanelTitleColor = Color.Black;
            this.GroupPanelTitleFont = new System.Drawing.Font("Tahoma", 9.25F, FontStyle.Bold);

            this.FlatButtonBackColor = GroupPanelBackColor;
            this.FlatButtonBorderColor = GroupPanelBackColor;
            this.FlatButtonForeColor = GroupPanelTitleColor;

            this.ToolBarBackColor = Color.FromArgb(255, 225, 223, 216);
            this.ToolBarForeColor = Color.Black;
            this.ToolBarFont = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Regular);

            this.FormLabelFont = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            this.FormFont = new System.Drawing.Font("Tahoma", 9.25F, FontStyle.Regular);

            this.FormLabelColor = Color.White;
            this.FormBackColor = Color.FromArgb(255, 100, 102, 120);

            this.FormLightLabelColor = Color.Black;
            this.FormLightBackColor = Color.White;
        }

    }
}
