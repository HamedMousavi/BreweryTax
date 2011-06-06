using System;
using System.ComponentModel;


namespace Entities
{

    public class GeneralType
    {
        public string Name { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }

        [BrowsableAttribute(false)]
        public string DetailsTable { get; set; }

        // Added to solve DataGridView ComboBox stupid databinding mechanism
        public GeneralType This
        {
            get { return this; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
