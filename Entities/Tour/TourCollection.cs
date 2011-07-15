using System;
using System.ComponentModel;


namespace Entities
{

    public class TourCollection : BindingList<Tour>
    {
        public DateTime Time { get; set; }


        private bool fireListChange;
        private ListChangedEventArgs lastListChange;


        public TourCollection()
        {
            this.fireListChange = false;
        }


        public void SuspendEvents()
        {
            this.fireListChange = false;
        }


        public void ResumeEvents()
        {
            this.fireListChange = true;
            if (this.lastListChange != null)
            {
                OnListChanged(this.lastListChange);
            }
        }


        protected override void OnListChanged(ListChangedEventArgs e)
        {

            if (this.fireListChange)
            {
                base.OnListChanged(e);
                this.lastListChange = null;
            }
            else
            {
                this.lastListChange = e;
            }
        }
    }
}
