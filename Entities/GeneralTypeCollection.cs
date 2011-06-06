using System.ComponentModel;


namespace Entities
{

    public class GeneralTypeCollection : BindingList<GeneralType>
    {
        public GeneralType GetById(int typeId)
        {
            foreach (GeneralType type in this)
            {
                if (type.Id == typeId)
                {
                    return type;
                }
            }

            return null;
        }
    }
}
