using System;
using Entities;


namespace DomainModel
{
    public class Cultures
    {
        private static CultureCollection cultures;


        public static void Init()
        {
            cultures = new CultureCollection();
            cultures.Add(new Culture("English", "en-us"));
            cultures.Add(new Culture("German", "de-DE"));
        }


        public static CultureCollection GetAll()
        {
            return cultures;
        }
    }
}
