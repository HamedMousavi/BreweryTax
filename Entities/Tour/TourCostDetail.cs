using System;


namespace Entities
{

    public class TourCostDetail : EntityBase
    {

        #region Fields

        protected TourCostGroup costGroup;
        protected Int32 signUpCount;
        protected Int32 participantsCount;
        protected Int32 id;
        
        #endregion Fields


        #region Properties
       
        public TourCostGroup CostGroup
        {
            get
            {
                return this.costGroup;
            }

            set
            {
                if (this.costGroup != value)
                {
                    this.costGroup = value;
                    RaisePropertyChanged("CostGroup");
                }
            }
        }

        public Int32 SignUpCount
        {
            get
            {
                return this.signUpCount;
            }

            set
            {
                if (this.signUpCount != value)
                {
                    this.signUpCount = value;
                    RaisePropertyChanged("SignUpCount");
                }
            }
        }

        public Int32 ParticipantsCount
        {
            get
            {
                return this.participantsCount;
            }

            set
            {
                if (this.participantsCount != value)
                {
                    this.participantsCount = value;
                    RaisePropertyChanged("ParticipantsCount");
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
        
        #endregion Properties


        public TourCostDetail()
        {
            this.id = -1;
        }


        public void CopyTo(TourCostDetail detail)
        {
            detail.SignUpCount = this.SignUpCount;
            detail.ParticipantsCount = this.ParticipantsCount;
            detail.Id = this.Id;
            detail.CostGroup = this.CostGroup;
            detail.IsDirty = this.IsDirty;
        }
    }
}
