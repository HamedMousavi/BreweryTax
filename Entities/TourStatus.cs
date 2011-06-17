using System;


namespace Entities
{

    public class TourStatus : EntityBase
    {

        protected string name;
        protected Int32 id;


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



        internal void CopyTo(TourStatus status)
        {
            status.Id = Id;
            status.Name = status.Name;
        }


        public override string ToString()
        {
            return this.Name;
        }
    }
}
