﻿using System;
using System.ComponentModel;


namespace Entities
{

    public class TourGroupCollection : BindingList<TourGroup>
    {
        public Int32 ServiceCount
        {
            get
            {
                Int32 sum = 0;

                foreach(Entities.TourGroup group in this)
                {
                    sum += group.Services.ClientCount;
                }

                return sum;
            }
        }


        internal Int32 GetServiceCountExcept(GeneralType serviceType)
        {
            Int32 sum = 0;

            foreach (Entities.TourGroup group in this)
            {
                sum += group.Services.GetClientCountExcept(serviceType);
            }

            return sum;
        }
    }
}
