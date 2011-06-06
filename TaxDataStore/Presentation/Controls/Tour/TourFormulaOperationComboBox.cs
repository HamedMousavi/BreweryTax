using System.Drawing;
using System.Windows.Forms;
using TaxDataStore.Presentation.Models;


namespace TaxDataStore.Presentation.Controls
{

    public class TourFormulaOperationComboBox : ComboBox
    {

        protected readonly int imagesize = 16;
        protected readonly int padding = 2;


        public TourFormulaOperationComboBox()
            : base()
        {
            this.DisplayMember = "Name";
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //base.OnDrawItem(e);
            if (e.Index >= 0)
            {
                e.DrawBackground();

                PriceOperationItem item = (PriceOperationItem)this.Items[e.Index];
                if (item != null)
                {
                    if (item.Image != null)
                    {
                        e.Graphics.DrawImage(item.Image, e.Bounds.X + padding, e.Bounds.Y, imagesize, imagesize);
                    }

                    e.Graphics.DrawString(
                        item.Name, this.Font, Brushes.Black,
                            new RectangleF(new PointF
                                (e.Bounds.X + imagesize + 2 * padding, e.Bounds.Y), e.Bounds.Size));
                }
                else
                {
                }

                e.DrawFocusRectangle();
            }
            else
            {
            }

            //base.OnDrawItem(e);
        }

    }
}
