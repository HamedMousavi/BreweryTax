using System;
using System.ComponentModel;


namespace Entities
{

    public class GeneralType : EntityBase
    {
        
        #region Fields

        protected string name;
        protected string detailsTable;
        protected Int32 id;

        #endregion Fields


        #region Properties
        
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    RaisePropertyChanged("Name");
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

        [BrowsableAttribute(false)]
        public string DetailsTable
        {
            get
            {
                return this.detailsTable;
            }

            set
            {
                if (this.detailsTable != value)
                {
                    this.detailsTable = value;
                    RaisePropertyChanged("DetailsTable");
                }
            }
        }
        
        #endregion Properties


        // Added to solve DataGridView ComboBox stupid databinding mechanism
        public GeneralType This
        {
            get { return this; }
        }


        public GeneralType()
        {
            this.Id = -1;
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}
