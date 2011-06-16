using System;
using System.ComponentModel;


namespace Entities
{

    public class CategoryClass
    {
        public string Name { get; set; }

        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public CategorySubCollection SubCategories { get; set; }


        public CategoryClass()
        {
            this.SubCategories = new CategorySubCollection();
        }


        public CategorySub GetSubByTypesCount(int rowIndex)
        {
            foreach (CategorySub sub in this.SubCategories)
            {
                if (sub.Types.Count > rowIndex)
                {
                    return sub;
                }
            }

            return null;
        }


        public void RemoveFromAllTypes(int rowIndex)
        {
            foreach (CategorySub sub in this.SubCategories)
            {
                if (sub.Types.Count > rowIndex)
                {
                    sub.Types.RemoveAt(rowIndex);
                }
            }
        }
    }
}
