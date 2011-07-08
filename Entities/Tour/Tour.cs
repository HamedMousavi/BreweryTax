using System;
using System.ComponentModel;


namespace Entities
{

    public class Tour : EntityBase
    {

        #region Fields

        protected Datetime time;
        protected TourGroupCollection groups;
        protected string comments;
        protected Int32 id;

        #endregion Fields


        #region Properties

        public Datetime Time 
        {
            get
            {
                return this.time;
            }

            set
            {
                if (this.time != value)
                {
                    this.time = value;
                    RaisePropertyChanged("Time");
                }
            }
        }

        public TourGroupCollection Groups
        {
            get
            {
                return this.groups;
            }

            set
            {
                if (this.groups != value)
                {
                    this.groups = value;
                    RaisePropertyChanged("Groups");
                }
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                if (this.comments != value)
                {
                    this.comments = value;
                    RaisePropertyChanged("Comments");
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


        public Tour()
        {
            this.time = new Datetime("HH:mm");
            this.time.PropertyChanged += new 
                PropertyChangedEventHandler(time_PropertyChanged);

            this.groups = new TourGroupCollection();
            
            this.id = -1;
        }


        void time_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Time.value changes and thus it doesn't directly updates
            // To understand time updates we must listen to it's changes
            RaisePropertyChanged("Time");
        }

        /*
        public Tour(TourCostGroupCollection CostGroups)
            : this()
        {
            foreach (TourCostGroup group in CostGroups)
            {
                TourCostDetail detail = new TourCostDetail();
                detail.CostGroup = group;

                this.CostDetails.Add(detail);
            }
        }
        */

        public void CopyTo(Tour tour)
        {
            this.Time.CopyTo(tour.Time);


            tour.Comments = this.Comments;

            tour.Id = this.Id;
            
            if (tour.Time != null) tour.Time.IsDirty = this.Time.IsDirty;

            tour.IsDirty = this.IsDirty;
        }


        public object ServiceCount
        {
            get
            {
                return this.groups.ServiceCount;
            }
        }
    }
}
