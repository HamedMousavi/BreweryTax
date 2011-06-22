using System;
using System.ComponentModel;


namespace Entities
{

    public class TourReceipt : EntityBase
    {

        protected TourReceiptItemCollection items;
        protected TourReceiptItemCollection deletedItems;
        protected Money total;


        public Money Total 
        {
            get
            {
                return total;
            }
            set
            {
                if (this.total != value)
                {
                    this.total = value;
                    RaisePropertyChanged("Total");
                }
            }
        }

        public TourReceiptItemCollection Items 
        {
            get
            {
                return items;
            }
            set
            {
                if (this.items != value)
                {
                    this.items = value;
                    RaisePropertyChanged("Items");
                }
            }
        }


        public TourReceipt()
        {
            this.total = new Money(00.00M, null);
            this.items = new TourReceiptItemCollection();
            this.deletedItems = new TourReceiptItemCollection();
        }


        internal void CopyTo(TourReceipt tourReceipt)
        {
            this.total.CopyTo(tourReceipt.Total);

            tourReceipt.Items.Clear();
            foreach (TourReceiptItem item in this.items)
            {
                TourReceiptItem newitem = new TourReceiptItem();
                item.CopyTo(newitem);

                tourReceipt.Items.Add(newitem);
            }
        }


        public bool Delete(TourReceiptItem item)
        {
            bool res = true;

            if (this.items.Contains(item))
            {
                res = this.items.Remove(item);
            }
            else
            {
            }

            if (res && !this.deletedItems.Contains(item) && item.Id > 0)
            {
                this.deletedItems.Add(item);
            }

            return res;
        }
    }
}
