using System.ComponentModel;


namespace Entities
{

    public class EntityBase : INotifyPropertyChanged
    {

        public EntityBase()
        {
            this.IsDirty = false;
        }


        public event PropertyChangedEventHandler PropertyChanged;


        [BrowsableAttribute(false)]
        public bool IsDirty { get; set; }

        /*
        public bool IsNew
        {
            get
            {
                return this.Id < 0;
            }
        }
        */

        protected void RaisePropertyChanged(string propertyName)
        {
            this.IsDirty = true;

            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
