using System.ComponentModel;


namespace Entities
{

    public class TourCostGroupCollection : BindingList<TourCostGroup>
    {
        public TourCostGroup GetById(int id)
        {
            foreach (TourCostGroup group in this)
            {
                if (group.Id == id) return group;
            }

            return null;
        }
    }
}
