using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Entities
{
    public class CategorySubCollection : BindingList<CategorySub>
    {
        public CategorySub this[string languageName]
        {
            get
            {
                foreach (CategorySub sub in this)
                {
                    if (string.Equals(sub.Language.LanguageName, languageName))
                    {
                        return sub;
                    }
                }

                return null;
            }
        }
    }
}
