using System;
using System.ComponentModel;


namespace Entities
{

    public class TourReceipt : EntityBase
    {

        protected BindingList<TourReceiptItem> items;
        protected TourReceiptItem total;


        public TourReceiptItem Total 
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

        public BindingList<TourReceiptItem> Items 
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
            this.total = new TourReceiptItem();
            this.items = new BindingList<TourReceiptItem>();
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
    }
}
