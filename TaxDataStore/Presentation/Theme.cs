using System.Drawing;

namespace TaxDataStore.Presentation
{
    public class Theme
    {
        public Color GroupPanelBackColor   { get; set; }  
        public Color GroupPanelTitleColor  { get; set; }  
                                           
        public Color FlatButtonBackColor   { get; set; }  
        public Color FlatButtonBorderColor { get; set; }  
        public Color FlatButtonForeColor   { get; set; }  
                                           
        public Font  ToolbarLabelFont      { get; set; }  
        public Color ToolbarLabelColor     { get; set; }  


        public Theme()
        {
            //(255, 210, 225, 245);
            // 255, 195, 205, 225

            GroupPanelBackColor = Color.FromArgb(255, 235, 235, 235);
            GroupPanelTitleColor = Color.FromArgb(255, 0, 0, 0);

            FlatButtonBackColor = Color.FromArgb(255, 235, 235, 235);
            FlatButtonBorderColor = Color.FromArgb(255, 235, 235, 235);
            FlatButtonForeColor = Color.Black;

            ToolbarLabelFont = new System.Drawing.Font("Tahoma", 8.25F, FontStyle.Bold);
            ToolbarLabelColor = Color.Black;
        }
    }
}
