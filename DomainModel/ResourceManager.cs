using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Drawing;

namespace DomainModel
{
    public class ResourceManager
    {
        private static Assembly res = Assembly.Load("Resources");
        private static System.Resources.ResourceManager textResMon = new System.Resources.ResourceManager("Resources.Texts", res);
        private static System.Resources.ResourceManager imgResMon = new System.Resources.ResourceManager("Resources.Images", res);

        private static Dictionary<string, string> stringCache = new Dictionary<string, string>();
        private static Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        private static CultureInfo englishCulture = new CultureInfo("en-US");
        private static CultureInfo culture;


        public ResourceManager(string locale)
        {
            culture = new CultureInfo(locale);
        }


        public string GetText(string resourceName)
        {
            if (culture == null)
            {
                culture = englishCulture;
            }

            if (!stringCache.ContainsKey(resourceName))
            {
                string res = textResMon.GetString(resourceName, culture) as string;
                if (!string.IsNullOrWhiteSpace(res))
                {
                    stringCache.Add(resourceName, res);
                }
            }

            if (stringCache.ContainsKey(resourceName))
            {
                return stringCache[resourceName];
            }
            else
            {
                return string.Empty;
            }
        }


        public Image GetImage(string resourceName)
        {
            if (!imageCache.ContainsKey(resourceName))
            {
                Image res = imgResMon.GetObject(resourceName, englishCulture) as Image;
                if (res != null)
                {
                    imageCache.Add(resourceName, res);
                }
            }

            if (imageCache.ContainsKey(resourceName))
            {
                return imageCache[resourceName];
            }
            else
            {
                return null;
            }
        }


        public void SetCulture(string cultureName)
        {
            if (culture == null ||
                !string.Equals(culture.Name, cultureName, System.StringComparison.InvariantCulture))
            {
                imageCache.Clear();
                stringCache.Clear();

                culture = new CultureInfo(cultureName);
            }
        }
    }
}
