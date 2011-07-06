using System;
using System.ComponentModel;


namespace Entities
{

    public class Contact : EntityBase
    {

        #region Fields

        protected GeneralType media;
        protected string value;
        protected Int32 id;

        #endregion Fields


        #region Properties

        public GeneralType Media
        {
            get
            {
                return this.media;
            }

            set
            {
                if (this.media != value)
                {
                    this.media = value;
                    RaisePropertyChanged("Media");
                }
            }
        }

        public string Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    RaisePropertyChanged("Value");
                }
            }
        }

        [BrowsableAttribute(false)]
        public Int32 Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        #endregion Properties


        public Contact()
        {
            //this.Media = new GeneralType();
            this.id = -1;
        }


        internal void CopyTo(Contact contact)
        {
            contact.Id = this.Id;
            contact.Media = this.Media;
            contact.Value = this.Value;
            contact.IsDirty = this.IsDirty;
        }
    }
}
