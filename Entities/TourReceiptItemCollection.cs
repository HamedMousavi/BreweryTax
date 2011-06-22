using System.ComponentModel;


namespace Entities
{

    public class TourReceiptItemCollection : BindingList<TourReceiptItem>
    {
        public void ClearNonCustomItems()
        {
            int count = Items.Count;
            for (int i = 0; i < count; i++)
            {
                TourReceiptItem item = Items[0];

                if (!item.IsCustom)
                {
                    Remove(item);
                }
            }
        }
    }
}
