using System;
using System.ComponentModel;


namespace Entities
{

    public class Culture
    {
        public string LanguageName { get; set; }
        public string CultureName { get; set; }
        
        [BrowsableAttribute(false)]
        public Int32 Id { get; set; }


        public Culture(string languageName, string culturName)
        {
            this.CultureName = culturName;
            this.LanguageName = languageName;
        }


        public Culture()
        {
        }
    }
}
