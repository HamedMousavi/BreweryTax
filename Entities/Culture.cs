
namespace Entities
{
    public class Culture
    {
        public string LanguageName { get; set; }
        public string CultureName { get; set; }


        public Culture(string languageName, string culturName)
        {
            this.CultureName = culturName;
            this.LanguageName = languageName;
        }
    }
}
