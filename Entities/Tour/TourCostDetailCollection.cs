using System.ComponentModel;
using System;


namespace Entities
{

    public class TourCostDetailCollection : BindingList<TourCostDetail>
    {

        internal void CopyTo(TourCostDetailCollection details)
        {
            details.Clear();

            foreach (TourCostDetail detail in this)
            {
                TourCostDetail detailCopy = new TourCostDetail();
                detail.CopyTo(detailCopy);

                details.Add(detailCopy);
            }
        }


        public int ServiceCount
        {
            get
            {
                Int32 participants = 0;
                Int32 signup = 0;

                foreach (TourCostDetail detail in this)
                {
                    participants += detail.ParticipantsCount;
                    signup += detail.SignUpCount;
                }

                if (participants <= 0)
                {
                    return signup;
                }
                else
                {
                    return participants;
                }
            }
        }


        public bool IsConfirmed
        {
            get
            {
                Int32 participants = 0;

                foreach (TourCostDetail detail in this)
                {
                    participants += detail.ParticipantsCount;
                }

                return (participants > 0);
            }
        }
    }
}
