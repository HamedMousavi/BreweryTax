using System;
using System.ComponentModel;


namespace Entities
{

    public class CultureCollection : BindingList<Entities.Culture>
    {

        public Entities.Culture Default { get; set; }

        public Entities.Culture this[string name]
        {
            get
            {
                foreach (Entities.Culture item in this)
                {
                    if (item.CultureName.Equals(name, StringComparison.InvariantCulture))
                    {
                        return item;
                    }
                }

                return null;
            }
        }
    }
}
